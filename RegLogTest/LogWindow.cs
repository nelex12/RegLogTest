using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkWithDb;

namespace RegLogTest
{
    public partial class LogWindow : Form
    {
        MainForm _parent;
        bool ClosedByPressX = true;
        public LogWindow(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void LogWindow_Load(object? sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        public void EnterButton_Click(object? sender, EventArgs e)
        {
            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            var userForCheck = new User(login, password);
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nelex\\source\\repos\\RegLogTest\\RegLogTest\\Database1.mdf;Integrated Security=True";
            DataBaseUserChecker checker = new DataBaseUserChecker(ConnectionString);
            if (checker.CheckUser(userForCheck))
            {
                MessageBox.Show("Вошел");
            }
            else
            {
                MessageBox.Show("Пользователя не существует");
            }
        }
        public void GoToRegWindow(object? sender, EventArgs e)
        {
            new RegWindow(_parent).Show();
            ClosedByPressX = false;
            this.Close();
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClosedByPressX)
            {
                _parent.Close();
            }

        }


        private void LogWindow_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
