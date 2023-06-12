using BudgetBuddy.sqldata;
using ExpenseTrackerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BudgetBuddy
{
    public partial class addexpense : UserControl
    {
        public addexpense()
        {
            InitializeComponent();
        }

        private void clear()
        {
            expNameTB.Clear();
            expAmountTB.Clear();
            expDesc.Clear();
            expCTG.SelectedIndex = 0;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expNameTB.Clear();
            expAmountTB.Clear();
            expDesc.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                if (expNameTB.Text == "" || expAmountTB.Text == "" || expDesc.Text == "" || expCTG.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    // Inserts the values from the textbox above to UserTbl
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl (ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser) values(@EN,@EA,@EC,@ED,@ECo,@EU)", con);
                    cmd.Parameters.AddWithValue("@EN", expNameTB.Text);
                    cmd.Parameters.AddWithValue("@EA", expAmountTB.Text);
                    cmd.Parameters.AddWithValue("@EC", expCTG.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDT.Value.Date);
                    cmd.Parameters.AddWithValue("@ECo", expDesc.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense added successfully!");
                    con.Close();
                    clear();
                }





            }






        }
    }
}
