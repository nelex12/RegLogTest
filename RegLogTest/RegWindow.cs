﻿using System;
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
    public partial class RegWindow : Form
    {
        MainForm _parent;
        bool ClosedByPressX = true;
        public RegWindow(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;

        }
        public void GoToLogWindow(object? sender, EventArgs e)
        {
            ClosedByPressX = false;
            new LogWindow(_parent).Show();
            this.Close();
        }
        public void RegBut_Click(object? sender, EventArgs e)
        {
            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            var userForAddToDB = new User(login, password);
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nelex\\source\\repos\\RegLogTest\\RegLogTest\\Database1.mdf;Integrated Security=True";
            DataBaseUserAdder Adder = new DataBaseUserAdder(ConnectionString);
            if(Adder.AddUser(userForAddToDB))
            {
                MessageBox.Show("Пользователь успешно добавлен");
            }
            else
            {
                MessageBox.Show("Не удалось добавить пользователя");
            }


        }

        private void RegWindow_Load(object sender, EventArgs e)
        {

        }

        private void RegWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClosedByPressX)
            {
                _parent.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegWindow_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
