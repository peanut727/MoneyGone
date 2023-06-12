namespace ExpenseTrackerSystem
{
    partial class mainmem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmem));
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            addexpense1 = new BudgetBuddy.addexpense();
            panel2 = new Panel();
            usrLBL = new Label();
            nameLBL = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 491);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(39, 164);
            button3.Name = "button3";
            button3.Size = new Size(164, 58);
            button3.TabIndex = 3;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(39, 36);
            button1.Name = "button1";
            button1.Size = new Size(164, 58);
            button1.TabIndex = 1;
            button1.Text = "View Expenses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(39, 100);
            button2.Name = "button2";
            button2.Size = new Size(164, 58);
            button2.TabIndex = 2;
            button2.Text = "Add Expenses";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkGreen;
            button4.Location = new Point(39, 410);
            button4.Name = "button4";
            button4.Size = new Size(164, 58);
            button4.TabIndex = 4;
            button4.Text = "Logout!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // addexpense1
            // 
            addexpense1.BackColor = Color.Ivory;
            addexpense1.Location = new Point(-1, 0);
            addexpense1.Name = "addexpense1";
            addexpense1.Size = new Size(943, 491);
            addexpense1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(usrLBL);
            panel2.Controls.Add(nameLBL);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 491);
            panel2.TabIndex = 5;
            // 
            // usrLBL
            // 
            usrLBL.AutoSize = true;
            usrLBL.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            usrLBL.ForeColor = Color.ForestGreen;
            usrLBL.Location = new Point(84, 9);
            usrLBL.Name = "usrLBL";
            usrLBL.Size = new Size(181, 33);
            usrLBL.TabIndex = 8;
            usrLBL.Text = "*insert user";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nameLBL.ForeColor = Color.ForestGreen;
            nameLBL.Location = new Point(65, 9);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(0, 23);
            nameLBL.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(88, 33);
            label3.TabIndex = 6;
            label3.Text = "Hello";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Ivory;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(206, 169);
            label2.Name = "label2";
            label2.Size = new Size(296, 22);
            label2.TabIndex = 4;
            label2.Text = "Your all in one expense tracker!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(144, 94);
            label1.Name = "label1";
            label1.Size = new Size(419, 75);
            label1.TabIndex = 3;
            label1.Text = "Money Gone";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(607, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // mainmem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(943, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(addexpense1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainmem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Money Gone";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private BudgetBuddy.addexpense addexpense1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label nameLBL;
        private Label label3;
        private Label usrLBL;
        private PictureBox pictureBox2;
    }
}