using BudgetBuddy;
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

namespace ExpenseTrackerSystem
{
    public partial class adminlogin : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // searches for adminTBL for the credentials
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("select count(*) from adminTbl where adminName='" + adminuserTB.Text + "' and adminPass='" + adminpassTB.Text + "'", con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                users userad = new users();
                userad.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Credential!");
            }
            con.Close();
        }
    }
}

