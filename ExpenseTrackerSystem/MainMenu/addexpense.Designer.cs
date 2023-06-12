namespace BudgetBuddy
{
    partial class addexpense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addexpense));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            expNameTB = new TextBox();
            expAmountTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            expDesc = new TextBox();
            expCTG = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ExpDT = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 70);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(89, 11);
            label1.Name = "label1";
            label1.Size = new Size(274, 43);
            label1.TabIndex = 0;
            label1.Text = "Add Expenses";
            // 
            // expNameTB
            // 
            expNameTB.BackColor = Color.Ivory;
            expNameTB.Location = new Point(115, 139);
            expNameTB.Multiline = true;
            expNameTB.Name = "expNameTB";
            expNameTB.Size = new Size(237, 30);
            expNameTB.TabIndex = 2;
            // 
            // expAmountTB
            // 
            expAmountTB.BackColor = Color.Ivory;
            expAmountTB.Location = new Point(115, 193);
            expAmountTB.Multiline = true;
            expAmountTB.Name = "expAmountTB";
            expAmountTB.Size = new Size(237, 30);
            expAmountTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(115, 118);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 4;
            label2.Text = "Expense Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(115, 172);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 5;
            label3.Text = "Expense Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(531, 118);
            label4.Name = "label4";
            label4.Size = new Size(177, 18);
            label4.TabIndex = 7;
            label4.Text = "Expense Description:";
            // 
            // expDesc
            // 
            expDesc.BackColor = Color.Ivory;
            expDesc.Location = new Point(531, 139);
            expDesc.Multiline = true;
            expDesc.Name = "expDesc";
            expDesc.Size = new Size(277, 110);
            expDesc.TabIndex = 6;
            // 
            // expCTG
            // 
            expCTG.BackColor = Color.Ivory;
            expCTG.FormattingEnabled = true;
            expCTG.Items.AddRange(new object[] { "Food", "Household", "Medical", "Travel", "Vehicle ", "Wants", "Others" });
            expCTG.Location = new Point(115, 361);
            expCTG.Name = "expCTG";
            expCTG.Size = new Size(237, 23);
            expCTG.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(115, 340);
            label5.Name = "label5";
            label5.Size = new Size(159, 18);
            label5.TabIndex = 9;
            label5.Text = "Expense Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(115, 267);
            label6.Name = "label6";
            label6.Size = new Size(123, 18);
            label6.TabIndex = 11;
            label6.Text = "Expense Date:";
            // 
            // ExpDT
            // 
            ExpDT.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ExpDT.Location = new Point(115, 300);
            ExpDT.Name = "ExpDT";
            ExpDT.Size = new Size(237, 21);
            ExpDT.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Ivory;
            button1.Location = new Point(531, 299);
            button1.Name = "button1";
            button1.Size = new Size(129, 59);
            button1.TabIndex = 13;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatAppearance.BorderColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Ivory;
            button2.Location = new Point(679, 299);
            button2.Name = "button2";
            button2.Size = new Size(129, 59);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addexpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "addexpense";
            Size = new Size(943, 491);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox expNameTB;
        private TextBox expAmountTB;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox expDesc;
        private ComboBox expCTG;
        private Label label5;
        private Label label6;
        private DateTimePicker ExpDT;
        private Button button1;
        private Button button2;
    }
}
