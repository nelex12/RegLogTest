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
        bool ClosedByPressX = true;
        public LogWindow(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void LogWindow_Load(object? sender, EventArgs e)
        {
        }
        public void EnterButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("123");
            _parent.Close();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
