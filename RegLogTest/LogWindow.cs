using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegLogTest
{
    public partial class LogWindow : Form
    {
        MainForm _parent;
        public LogWindow(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            _parent.Hide();
        }
        
        public void LogWindow_Load(object? sender, EventArgs e)
        {
            _parent.Hide();
        }
        public void EnterButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("123");
            _parent.Close();
        }
        public void GoToRegWindow(object? sender, EventArgs e)
        {
            new RegWindow(_parent).Show();
            this.Close();
        }


    }
}
