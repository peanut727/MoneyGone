namespace BudgetBuddy
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            UDOB = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            UPasswordTB = new TextBox();
            UNameTB = new TextBox();
            label4 = new Label();
            UNumberTB = new TextBox();
            label5 = new Label();
            UAddressTB = new TextBox();
            label7 = new Label();
            UAddBtn = new Button();
            button1 = new Button();
            UserDGV = new DataGridView();
            UserID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            SelectedID = new TextBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 70);
            panel1.TabIndex = 3;
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
            // UDOB
            // 
            UDOB.CustomFormat = "";
            UDOB.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UDOB.Location = new Point(353, 140);
            UDOB.Name = "UDOB";
            UDOB.Size = new Size(237, 21);
            UDOB.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Ivory;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(353, 120);
            label6.Name = "label6";
            label6.Size = new Size(150, 18);
            label6.TabIndex = 17;
            label6.Text = "User Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(90, 174);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(90, 120);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // UPasswordTB
            // 
            UPasswordTB.BackColor = Color.White;
            UPasswordTB.Location = new Point(90, 195);
            UPasswordTB.Multiline = true;
            UPasswordTB.Name = "UPasswordTB";
            UPasswordTB.PasswordChar = '*';
            UPasswordTB.Size = new Size(237, 21);
            UPasswordTB.TabIndex = 14;
            UPasswordTB.UseSystemPasswordChar = true;
            // 
            // UNameTB
            // 
            UNameTB.BackColor = Color.White;
            UNameTB.Location = new Point(90, 141);
            UNameTB.Multiline = true;
            UNameTB.Name = "UNameTB";
            UNameTB.Size = new Size(237, 21);
            UNameTB.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(619, 120);
            label4.Name = "label4";
            label4.Size = new Size(126, 18);
            label4.TabIndex = 20;
            label4.Text = "Phone Number";
            // 
            // UNumberTB
            // 
            UNumberTB.BackColor = Color.White;
            UNumberTB.Location = new Point(619, 140);
            UNumberTB.Multiline = true;
            UNumberTB.Name = "UNumberTB";
            UNumberTB.Size = new Size(237, 21);
            UNumberTB.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Ivory;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(619, 174);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 22;
            label5.Text = "Address";
            // 
            // UAddressTB
            // 
            UAddressTB.BackColor = Color.White;
            UAddressTB.Location = new Point(619, 194);
            UAddressTB.Multiline = true;
            UAddressTB.Name = "UAddressTB";
            UAddressTB.Size = new Size(237, 57);
            UAddressTB.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Ivory;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(796, 73);
            label7.Name = "label7";
            label7.Size = new Size(188, 28);
            label7.TabIndex = 23;
            label7.Text = "View Expenses";
            label7.Click += label7_Click;
            // 
            // UAddBtn
            // 
            UAddBtn.BackColor = Color.DarkGreen;
            UAddBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            UAddBtn.FlatStyle = FlatStyle.Flat;
            UAddBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UAddBtn.ForeColor = Color.Ivory;
            UAddBtn.Location = new Point(786, 323);
            UAddBtn.Name = "UAddBtn";
            UAddBtn.Size = new Size(156, 40);
            UAddBtn.TabIndex = 25;
            UAddBtn.Text = "Add User";
            UAddBtn.UseVisualStyleBackColor = false;
            UAddBtn.Click += UAddBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Ivory;
            button1.Location = new Point(786, 598);
            button1.Name = "button1";
            button1.Size = new Size(156, 40);
            button1.TabIndex = 26;
            button1.Text = "Delete User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserDGV
            // 
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(105, 257);
            UserDGV.Name = "UserDGV";
            UserDGV.RowTemplate.Height = 25;
            UserDGV.Size = new Size(640, 381);
            UserDGV.TabIndex = 27;
            // 
            // UserID
            // 
            UserID.Location = new Point(786, 569);
            UserID.Name = "UserID";
            UserID.Size = new Size(156, 23);
            UserID.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Ivory;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(786, 548);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 29;
            label8.Text = "User ID:";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatAppearance.BorderColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Ivory;
            button2.Location = new Point(890, 416);
            button2.Name = "button2";
            button2.Size = new Size(52, 29);
            button2.TabIndex = 30;
            button2.Text = "Edit User";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SelectedID
            // 
            SelectedID.Location = new Point(806, 422);
            SelectedID.Name = "SelectedID";
            SelectedID.Size = new Size(68, 23);
            SelectedID.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Ivory;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(806, 401);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 32;
            label9.Text = "User ID:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(817, 450);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(988, 711);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(SelectedID);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(UserID);
            Controls.Add(UserDGV);
            Controls.Add(button1);
            Controls.Add(UAddBtn);
            Controls.Add(label7);
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
            Name = "users";
            Text = "users";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private DateTimePicker UDOB;
        private Label label6;
        private Label label3;
        private Label label2;
        private TextBox UPasswordTB;
        private TextBox UNameTB;
        private Label label4;
        private TextBox UNumberTB;
        private Label label5;
        private TextBox UAddressTB;
        private Label label7;
        private Button UAddBtn;
        private Button button1;
        private DataGridView UserDGV;
        private TextBox UserID;
        private Label label8;
        private Button button2;
        private TextBox SelectedID;
        private Label label9;
        private PictureBox pictureBox2;
    }
}