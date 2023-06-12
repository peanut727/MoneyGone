namespace BudgetBuddy
{
    partial class EditValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditValues));
            button2 = new Button();
            ExpDT = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            expCTG = new ComboBox();
            label4 = new Label();
            expDesc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            expAmountTB = new TextBox();
            expNameTB = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            selectedID = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatAppearance.BorderColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Ivory;
            button2.Location = new Point(491, 281);
            button2.Name = "button2";
            button2.Size = new Size(147, 40);
            button2.TabIndex = 28;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ExpDT
            // 
            ExpDT.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ExpDT.Location = new Point(103, 323);
            ExpDT.Name = "ExpDT";
            ExpDT.Size = new Size(270, 21);
            ExpDT.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(103, 292);
            label6.Name = "label6";
            label6.Size = new Size(123, 18);
            label6.TabIndex = 25;
            label6.Text = "Expense Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(103, 360);
            label5.Name = "label5";
            label5.Size = new Size(159, 18);
            label5.TabIndex = 24;
            label5.Text = "Expense Category:";
            // 
            // expCTG
            // 
            expCTG.BackColor = Color.Ivory;
            expCTG.FormattingEnabled = true;
            expCTG.Items.AddRange(new object[] { "Food", "Household", "Medical", "Travel", "Vehicle ", "Wants", "Others" });
            expCTG.Location = new Point(103, 380);
            expCTG.Name = "expCTG";
            expCTG.Size = new Size(270, 22);
            expCTG.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(407, 153);
            label4.Name = "label4";
            label4.Size = new Size(177, 18);
            label4.TabIndex = 22;
            label4.Text = "Expense Description:";
            // 
            // expDesc
            // 
            expDesc.BackColor = Color.Ivory;
            expDesc.Location = new Point(407, 173);
            expDesc.Multiline = true;
            expDesc.Name = "expDesc";
            expDesc.Size = new Size(316, 103);
            expDesc.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(103, 203);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 20;
            label3.Text = "Expense Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(103, 153);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 19;
            label2.Text = "Expense Name:";
            // 
            // expAmountTB
            // 
            expAmountTB.BackColor = Color.Ivory;
            expAmountTB.Location = new Point(103, 223);
            expAmountTB.Multiline = true;
            expAmountTB.Name = "expAmountTB";
            expAmountTB.Size = new Size(270, 28);
            expAmountTB.TabIndex = 18;
            // 
            // expNameTB
            // 
            expNameTB.BackColor = Color.Ivory;
            expNameTB.Location = new Point(103, 173);
            expNameTB.Multiline = true;
            expNameTB.Name = "expNameTB";
            expNameTB.Size = new Size(270, 28);
            expNameTB.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 65);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(102, 10);
            label1.Name = "label1";
            label1.Size = new Size(272, 43);
            label1.TabIndex = 0;
            label1.Text = "Edit Expenses";
            // 
            // selectedID
            // 
            selectedID.BackColor = Color.Ivory;
            selectedID.Location = new Point(222, 105);
            selectedID.Name = "selectedID";
            selectedID.Size = new Size(49, 21);
            selectedID.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Ivory;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(104, 108);
            label7.Name = "label7";
            label7.Size = new Size(102, 18);
            label7.TabIndex = 30;
            label7.Text = "Expense ID:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(282, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 130);
            label8.Name = "label8";
            label8.Size = new Size(48, 14);
            label8.TabIndex = 32;
            label8.Text = "Search";
            // 
            // EditValues
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(747, 476);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(selectedID);
            Controls.Add(button2);
            Controls.Add(ExpDT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(expCTG);
            Controls.Add(label4);
            Controls.Add(expDesc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(expAmountTB);
            Controls.Add(expNameTB);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "EditValues";
            Text = "EditValues";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DateTimePicker ExpDT;
        private Label label6;
        private Label label5;
        private ComboBox expCTG;
        private Label label4;
        private TextBox expDesc;
        private Label label3;
        private Label label2;
        private TextBox expAmountTB;
        private TextBox expNameTB;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox selectedID;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label8;
    }
}