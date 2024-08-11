namespace RegLogTest
{
    partial class RegWindow
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
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(366, 28);
            button1.Name = "button1";
            button1.Size = new Size(132, 34);
            button1.TabIndex = 1;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegBut_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 31);
            button2.Name = "button2";
            button2.Size = new Size(132, 28);
            button2.TabIndex = 0;
            button2.Text = "К окну входа";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GoToLogWindow;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(534, 68);
            label1.TabIndex = 2;
            label1.Text = "Окно регистрации";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 68);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 373);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(128, 174);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 7;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(142, 118);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 6;
            label2.Text = "Логин:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 68);
            panel3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 3;
            // 
            // RegWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegWindow";
            Text = "Регистрация";
            FormClosing += RegWindow_FormClosing;
            Load += RegWindow_Load;
            Shown += RegWindow_Shown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel panel3;
    }
}