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
using System.Xml.Linq;

namespace BudgetBuddy
{
    public partial class EditValues : Form
    {
        public EditValues()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(expAmountTB.Text);
            int ID = Convert.ToInt32(selectedID.Text);


            if (selectedID.Text == "")
            {
                MessageBox.Show("Missing ID!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ExpenseTbl SET ExpName=@EN, ExpAmt=@EA, ExpCat=@EC, ExpDate=@ED, ExpDesc=@ECo WHERE ExpId=@ID", con);
                cmd.Parameters.AddWithValue("@EN", expNameTB.Text);
                cmd.Parameters.AddWithValue("@EA", amount);
                cmd.Parameters.AddWithValue("@EC", expCTG.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", ExpDT.Value.Date);
                cmd.Parameters.AddWithValue("@ECo", expDesc.Text);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expense updated successfully!");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Retrieves the values from the ExpenseTbl table for the specified ID
            try
            {

                con.Open();
                int ID = Convert.ToInt32(selectedID.Text);
                SqlCommand cmd = new SqlCommand("SELECT ExpName, ExpAmt, ExpCat, ExpDate, ExpDesc FROM ExpenseTbl WHERE ExpId=@ID AND ExpUser=@USER", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@USER", Login.User);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    expNameTB.Text = reader["ExpName"].ToString();
                    expAmountTB.Text = reader["ExpAmt"].ToString();
                    expCTG.SelectedItem = reader["ExpCat"].ToString();
                    ExpDT.Value = Convert.ToDateTime(reader["ExpDate"]);
                    expDesc.Text = reader["ExpDesc"].ToString();
                }
                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                selectedID.Text = "";
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
