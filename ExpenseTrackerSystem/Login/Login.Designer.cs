namespace ExpenseTrackerSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            UNameTB = new TextBox();
            UPassTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginbt = new Button();
            label6 = new Label();
            about1 = new BudgetBuddy.about();
            splash1 = new BudgetBuddy.splash();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 423);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(10, 110);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 12;
            label7.Text = "LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 172);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(9, 239);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 9;
            label5.Text = "ABOUT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(24, 371);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 9;
            label4.Text = "EXIT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(183, 61);
            label1.Name = "label1";
            label1.Size = new Size(314, 55);
            label1.TabIndex = 1;
            label1.Text = "Money Gone";
            // 
            // UNameTB
            // 
            UNameTB.BackColor = Color.Ivory;
            UNameTB.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTB.ForeColor = Color.DarkGreen;
            UNameTB.Location = new Point(163, 188);
            UNameTB.Multiline = true;
            UNameTB.Name = "UNameTB";
            UNameTB.Size = new Size(363, 47);
            UNameTB.TabIndex = 3;
            // 
            // UPassTB
            // 
            UPassTB.BackColor = Color.Ivory;
            UPassTB.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UPassTB.ForeColor = Color.DarkGreen;
            UPassTB.Location = new Point(162, 282);
            UPassTB.Multiline = true;
            UPassTB.Name = "UPassTB";
            UPassTB.PasswordChar = '*';
            UPassTB.Size = new Size(363, 47);
            UPassTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(163, 163);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(163, 257);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // loginbt
            // 
            loginbt.BackColor = Color.Green;
            loginbt.FlatAppearance.BorderColor = Color.Green;
            loginbt.FlatAppearance.BorderSize = 3;
            loginbt.FlatStyle = FlatStyle.Flat;
            loginbt.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginbt.ForeColor = Color.White;
            loginbt.Location = new Point(283, 335);
            loginbt.Name = "loginbt";
            loginbt.Size = new Size(109, 39);
            loginbt.TabIndex = 8;
            loginbt.Text = "LOGIN";
            loginbt.UseVisualStyleBackColor = false;
            loginbt.Click += loginbt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Honeydew;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(492, 404);
            label6.Name = "label6";
            label6.Size = new Size(80, 14);
            label6.TabIndex = 9;
            label6.Text = "Admin Login";
            label6.Click += label6_Click;
            // 
            // about1
            // 
            about1.Location = new Point(113, 0);
            about1.Name = "about1";
            about1.Size = new Size(463, 423);
            about1.TabIndex = 10;
            // 
            // splash1
            // 
            splash1.BackColor = Color.Ivory;
            splash1.Location = new Point(113, 0);
            splash1.Name = "splash1";
            splash1.Size = new Size(463, 423);
            splash1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Honeydew;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(120, 404);
            label8.Name = "label8";
            label8.Size = new Size(97, 14);
            label8.TabIndex = 12;
            label8.Text = "Create Account";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(192, 115);
            label9.Name = "label9";
            label9.Size = new Size(296, 22);
            label9.TabIndex = 13;
            label9.Text = "Your all in one expense tracker!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(577, 423);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(loginbt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UPassTB);
            Controls.Add(UNameTB);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(splash1);
            Controls.Add(about1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox UNameTB;
        private TextBox UPassTB;
        private Label label2;
        private Label label3;
        private Button loginbt;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label6;
        private BudgetBuddy.about about1;
        private Label label7;
        private PictureBox pictureBox1;
        private BudgetBuddy.splash splash1;
        private Label label8;
        private Label label9;
    }
}