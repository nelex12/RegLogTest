namespace RegLogTest
{
    partial class LogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(394, 33);
            button1.Name = "button1";
            button1.Size = new Size(128, 30);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EnterButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 78);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(45, 33);
            button2.Name = "button2";
            button2.Size = new Size(128, 33);
            button2.TabIndex = 1;
            button2.Text = "К окну регистрации";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GoToRegWindow;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 363);
            panel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(120, 174);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 5;
            label3.Text = "Пароль:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(134, 121);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 4;
            label2.Text = "Логин:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(534, 63);
            label1.TabIndex = 3;
            label1.Text = "Окно входа";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 1;
            // 
            // LogWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 441);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogWindow";
            Text = "Вход";
            FormClosing += LogWindow_FormClosing;
            Load += LogWindow_Load;
            Shown += LogWindow_Shown;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}