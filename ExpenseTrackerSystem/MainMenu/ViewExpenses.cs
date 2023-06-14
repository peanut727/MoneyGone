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
using System.Globalization;

namespace BudgetBuddy
{
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
            ShowExpenses();
            GetTotExp();
        }
        SqlConnection con = DBConnection.GetConnection();
        private void GetTotExp()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string value = dt.Rows[0][0].ToString();
            decimal moneyval;

            if (Decimal.TryParse(value, out moneyval))
            {
               totamnt.Text = moneyval.ToString("C");
            }
            //totamnt.Text = "PHP" + dt.Rows[0][0].ToString();
            con.Close();
        }

        private void ShowExpenses()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "select * from ExpenseTbl where ExpUser='" + Login.User + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
                var ds = new DataSet();
                SDA.Fill(ds);
                ViewUserDGV.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmem menu = new mainmem();
            menu.Show();
        }

        //delete
        private void login_Click(object sender, EventArgs e)
        {
            // Deletes the user with the specified ID from ExpenseTbl
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ExpenseTbl WHERE ExpId = @Eid", con);
            cmd.Parameters.AddWithValue("@Eid", expID.Text);
            int rowsDeleted = cmd.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                MessageBox.Show("Expense deleted successfully!");
                con.Close();
                ShowExpenses();
            }
            else
            {
                MessageBox.Show("Expense not found!");
            }
            con.Close();
        }

        private void EditVal_Click(object sender, EventArgs e)
        {
            EditValues edit = new EditValues();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowExpenses();
            GetTotExp();
        }
    }
}
