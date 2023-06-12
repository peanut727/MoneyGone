namespace BudgetBuddy
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ViewUserDGV = new DataGridView();
            label2 = new Label();
            totamnt = new Label();
            DeleteVal = new Button();
            expID = new TextBox();
            EditVal = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewUserDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 70);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.ForestGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(92, 11);
            label1.Name = "label1";
            label1.Size = new Size(288, 43);
            label1.TabIndex = 2;
            label1.Text = "View Expenses";
            // 
            // ViewUserDGV
            // 
            ViewUserDGV.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewUserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewUserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewUserDGV.GridColor = Color.DarkGreen;
            ViewUserDGV.Location = new Point(39, 109);
            ViewUserDGV.Name = "ViewUserDGV";
            ViewUserDGV.RowTemplate.Height = 25;
            ViewUserDGV.Size = new Size(732, 429);
            ViewUserDGV.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(38, 551);
            label2.Name = "label2";
            label2.Size = new Size(269, 43);
            label2.TabIndex = 3;
            label2.Text = "Total Amount:";
            // 
            // totamnt
            // 
            totamnt.AutoSize = true;
            totamnt.BackColor = Color.Ivory;
            totamnt.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            totamnt.ForeColor = Color.DarkGreen;
            totamnt.Location = new Point(298, 551);
            totamnt.Name = "totamnt";
            totamnt.Size = new Size(153, 43);
            totamnt.TabIndex = 4;
            totamnt.Text = "amount";
            // 
            // DeleteVal
            // 
            DeleteVal.BackColor = Color.DarkGreen;
            DeleteVal.FlatAppearance.BorderColor = Color.DarkGreen;
            DeleteVal.FlatAppearance.BorderSize = 3;
            DeleteVal.FlatStyle = FlatStyle.Flat;
            DeleteVal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteVal.ForeColor = Color.White;
            DeleteVal.Location = new Point(799, 503);
            DeleteVal.Name = "DeleteVal";
            DeleteVal.Size = new Size(135, 36);
            DeleteVal.TabIndex = 5;
            DeleteVal.Text = "Delete Values";
            DeleteVal.UseVisualStyleBackColor = false;
            DeleteVal.Click += login_Click;
            // 
            // expID
            // 
            expID.Location = new Point(799, 457);
            expID.Multiline = true;
            expID.Name = "expID";
            expID.Size = new Size(135, 40);
            expID.TabIndex = 29;
            // 
            // EditVal
            // 
            EditVal.BackColor = Color.DarkGreen;
            EditVal.FlatAppearance.BorderColor = Color.DarkGreen;
            EditVal.FlatAppearance.BorderSize = 3;
            EditVal.FlatStyle = FlatStyle.Flat;
            EditVal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditVal.ForeColor = Color.White;
            EditVal.Location = new Point(799, 109);
            EditVal.Name = "EditVal";
            EditVal.Size = new Size(135, 36);
            EditVal.TabIndex = 30;
            EditVal.Text = "Edit Values";
            EditVal.UseVisualStyleBackColor = false;
            EditVal.Click += EditVal_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(799, 170);
            button1.Name = "button1";
            button1.Size = new Size(135, 36);
            button1.TabIndex = 31;
            button1.Text = "Refresh Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewExpenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(963, 613);
            Controls.Add(button1);
            Controls.Add(EditVal);
            Controls.Add(expID);
            Controls.Add(DeleteVal);
            Controls.Add(totamnt);
            Controls.Add(label2);
            Controls.Add(ViewUserDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewExpenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewExpenses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewUserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView ViewUserDGV;
        private Label label2;
        private Label totamnt;
        private Button DeleteVal;
        private TextBox expID;
        private Button EditVal;
        private Button button1;
    }
}