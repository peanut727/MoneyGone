namespace ExpenseTrackerSystem
{
    partial class adminlogin
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
            panel1 = new Panel();
            label1 = new Label();
            adminuserTB = new TextBox();
            adminpassTB = new TextBox();
            login = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 20);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // adminuserTB
            // 
            adminuserTB.BackColor = Color.Ivory;
            adminuserTB.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            adminuserTB.ForeColor = Color.DarkGreen;
            adminuserTB.Location = new Point(80, 152);
            adminuserTB.Multiline = true;
            adminuserTB.Name = "adminuserTB";
            adminuserTB.Size = new Size(210, 33);
            adminuserTB.TabIndex = 1;
            // 
            // adminpassTB
            // 
            adminpassTB.BackColor = Color.Ivory;
            adminpassTB.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            adminpassTB.ForeColor = Color.DarkGreen;
            adminpassTB.Location = new Point(80, 224);
            adminpassTB.Multiline = true;
            adminpassTB.Name = "adminpassTB";
            adminpassTB.PasswordChar = '*';
            adminpassTB.Size = new Size(210, 33);
            adminpassTB.TabIndex = 2;
            // 
            // login
            // 
            login.BackColor = Color.DarkGreen;
            login.FlatAppearance.BorderColor = Color.DarkGreen;
            login.FlatAppearance.BorderSize = 3;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = Color.White;
            login.Location = new Point(134, 274);
            login.Name = "login";
            login.Size = new Size(94, 36);
            login.TabIndex = 3;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 131);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 4;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 203);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // adminlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(374, 381);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login);
            Controls.Add(adminpassTB);
            Controls.Add(adminuserTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "adminlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminlogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox adminuserTB;
        private TextBox adminpassTB;
        private Button login;
        private Label label2;
        private Label label3;
    }
}