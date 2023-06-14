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
    public partial class usersignup : Form
    {
        public usersignup()
        {
            InitializeComponent();
        }
        SqlConnection con = DBConnection.GetConnection();
        private void Clear()
        {
            UNameTB.Text = "";
            UNumberTB.Text = "";
            UPasswordTB.Text = "";
            UAddressTB.Text = "";
        }
        private void loginbt_Click(object sender, EventArgs e)
        {
            if (UNameTB.Text == "" || UNumberTB.Text == "" || UPasswordTB.Text == "" || UAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                // Inserts the values from the textbox above to UserTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl (UName,UDOB,UNum,UPass,UAddress) values(@UN,@UD,@UP,@UPA,@UA)", con);
                cmd.Parameters.AddWithValue("@UN", UNameTB.Text);
                cmd.Parameters.AddWithValue("@UD", UDOB.Value.Date);
                cmd.Parameters.AddWithValue("@UP", UNumberTB.Text);
                cmd.Parameters.AddWithValue("@UPA", UPasswordTB.Text);
                cmd.Parameters.AddWithValue("@UA", UAddressTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully!");
                con.Close();
                Clear();
                // redirects back to Login Screen
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }
    }
}
