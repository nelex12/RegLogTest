namespace RegLogTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            new LogWindow(this).Show();
        }
        public void MainForm_Load(object? sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
