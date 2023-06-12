namespace BudgetBuddy
{
    partial class usersignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usersignup));
            label5 = new Label();
            UAddressTB = new TextBox();
            label4 = new Label();
            UNumberTB = new TextBox();
            UDOB = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            UPasswordTB = new TextBox();
            UNameTB = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            loginbt = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Ivory;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(58, 322);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 34;
            label5.Text = "Address";
            // 
            // UAddressTB
            // 
            UAddressTB.BackColor = Color.Ivory;
            UAddressTB.Location = new Point(58, 342);
            UAddressTB.Multiline = true;
            UAddressTB.Name = "UAddressTB";
            UAddressTB.Size = new Size(237, 57);
            UAddressTB.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(58, 268);
            label4.Name = "label4";
            label4.Size = new Size(126, 18);
            label4.TabIndex = 32;
            label4.Text = "Phone Number";
            // 
            // UNumberTB
            // 
            UNumberTB.BackColor = Color.Ivory;
            UNumberTB.Location = new Point(58, 288);
            UNumberTB.Multiline = true;
            UNumberTB.Name = "UNumberTB";
            UNumberTB.Size = new Size(237, 21);
            UNumberTB.TabIndex = 31;
            // 
            // UDOB
            // 
            UDOB.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UDOB.Location = new Point(58, 235);
            UDOB.Name = "UDOB";
            UDOB.Size = new Size(237, 21);
            UDOB.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Ivory;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(58, 215);
            label6.Name = "label6";
            label6.Size = new Size(150, 18);
            label6.TabIndex = 29;
            label6.Text = "User Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(58, 170);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(58, 116);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 27;
            label2.Text = "Username";
            // 
            // UPasswordTB
            // 
            UPasswordTB.BackColor = Color.Ivory;
            UPasswordTB.Location = new Point(58, 191);
            UPasswordTB.Multiline = true;
            UPasswordTB.Name = "UPasswordTB";
            UPasswordTB.PasswordChar = '*';
            UPasswordTB.Size = new Size(237, 21);
            UPasswordTB.TabIndex = 26;
            UPasswordTB.UseSystemPasswordChar = true;
            // 
            // UNameTB
            // 
            UNameTB.BackColor = Color.Ivory;
            UNameTB.Location = new Point(58, 137);
            UNameTB.Multiline = true;
            UNameTB.Name = "UNameTB";
            UNameTB.Size = new Size(237, 21);
            UNameTB.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 70);
            panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(89, 11);
            label1.Name = "label1";
            label1.Size = new Size(125, 43);
            label1.TabIndex = 0;
            label1.Text = "Users";
            // 
            // loginbt
            // 
            loginbt.BackColor = Color.Green;
            loginbt.FlatAppearance.BorderColor = Color.Green;
            loginbt.FlatAppearance.BorderSize = 3;
            loginbt.FlatStyle = FlatStyle.Flat;
            loginbt.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginbt.ForeColor = Color.White;
            loginbt.Location = new Point(120, 423);
            loginbt.Name = "loginbt";
            loginbt.Size = new Size(109, 39);
            loginbt.TabIndex = 35;
            loginbt.Text = "SIGNUP";
            loginbt.UseVisualStyleBackColor = false;
            loginbt.Click += loginbt_Click;
            // 
            // usersignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(358, 543);
            Controls.Add(loginbt);
            Controls.Add(label5);
            Controls.Add(UAddressTB);
            Controls.Add(label4);
            Controls.Add(UNumberTB);
            Controls.Add(UDOB);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UPasswordTB);
            Controls.Add(UNameTB);
            Controls.Add(panel1);
            Name = "usersignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usersignup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox UAddressTB;
        private Label label4;
        private TextBox UNumberTB;
        private DateTimePicker UDOB;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox UPasswordTB;
        private TextBox UNameTB;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button loginbt;
    }
}