using WorkWithDb;

namespace RegLogTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            new LogWindow(this).Show();
            this.Hide();
        }
        public void MainForm_Load(object? sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
