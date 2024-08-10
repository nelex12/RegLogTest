namespace WorkWithDb;

using Microsoft.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

/// Да, класс представляет пользователя и
/// хранит пароль в виде простой строки,однако это безопасно т.к.
/// экземпляры классы существуют лишь локально пока приложение сидит в оперативке и пароль используется 
/// лишь для входа и регистрации. Сервера, то нет
class User
{
    private string Login { get; set; }
    private string Password { get; set; }
    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }
    public string[] GetDataForDB()
    {
        return [Login, GetPasswordHash()];
    }

    private string GetPasswordHash()
    {
        byte[] source;
        byte[] hash;
        source = ASCIIEncoding.ASCII.GetBytes(Password);
        hash = new MD5CryptoServiceProvider().ComputeHash(source);
        StringBuilder sb = new StringBuilder();

        string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        return ByteArrayToString(hash);
    }

}


class DataBaseUserAdder
{
    private string _connectionString;
    private SqlConnection _connection;

    public DataBaseUserAdder(string connectionString)
    {
        _connectionString = connectionString;
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }

    public bool AddUser(User currentUser)
    {
        string[] currentUserData = currentUser.GetDataForDB();
        string currentUserLogin = currentUserData[0];
        string currentUserPasswordHash = currentUserData[1];

        var commandForAddUser = new SqlCommand("INSERT INTO Users (Login, Password) VALUES (@Login, @Password)", _connection);
        commandForAddUser.Parameters.AddWithValue("Login", currentUserLogin);
        commandForAddUser.Parameters.AddWithValue("Password", currentUserPasswordHash);

        return (commandForAddUser.ExecuteNonQuery() == 1);
    }
}



class DataBaseUserChecker
{
    private string _connectionString;
    private SqlConnection _connection;

    public DataBaseUserChecker(string connectionString)
    {
        _connectionString = connectionString;
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }
    public bool CheckUser(User user)
    {
        //select * from table where id in (1, 2, 3, 4 ....)
        string[] userData = user.GetDataForDB();
        string checkingLogin = userData[0];
        string checkingPassword = userData[1];
        SqlCommand commandForCheckUser = new SqlCommand($"SELECT Password FROM Users WHERE Login = @checkingLogin", _connection);
        commandForCheckUser.Parameters.AddWithValue("checkingLogin", checkingLogin);
        var reader = commandForCheckUser.ExecuteReader();
        if (reader.Read())
        {
            return reader.GetValue(0).ToString() == checkingPassword;
        }
        else
        {
            return false;
        }

    }
}