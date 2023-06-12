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
    public partial class adminexpenses : Form
    {
        public adminexpenses()
        {
            InitializeComponent();
            ShowExpenses();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowExpenses()
        {
            con.Open();
            string query = "select * from ExpenseTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            adminexDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            users user = new users();
            user.Show();
        }
    }
}
