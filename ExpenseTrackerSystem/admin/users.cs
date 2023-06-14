using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ExpenseTrackerSystem;

namespace BudgetBuddy
{
    public partial class users : Form
    {
        SqlConnection con = DBConnection.GetConnection();
        public users()
        {
            InitializeComponent();
            ShowUser();
        }
        private void Clear()
        {
            UNameTB.Text = "";
            UNumberTB.Text = "";
            UPasswordTB.Text = "";
            UAddressTB.Text = "";
        }
        private void ShowUser()
        {
            con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();

        }

        private void UAddBtn_Click(object sender, EventArgs e)
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
                ShowUser();
                Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deletes the user with the specified ID from UserTbl
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE Uid = @Uid", con);
            cmd.Parameters.AddWithValue("@Uid", UserID.Text);
            int rowsDeleted = cmd.ExecuteNonQuery();
            if (rowsDeleted > 0)
            {
                MessageBox.Show("User deleted successfully!");
                con.Close();
                ShowUser();
            }
            else
            {
                MessageBox.Show("User not found!");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(SelectedID.Text);
            if (SelectedID.Text == "")
            {
                MessageBox.Show("Missing ID!");
            }
            else
            {
                // Updates the values from the UserTbl
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET UName=@UN, UDOB=@DOB, UNum=@UNUM, UPass=@UP, UAddress=@UA WHERE UId=@ID", con);
                cmd.Parameters.AddWithValue("@UN", UNameTB.Text);
                cmd.Parameters.AddWithValue("@DOB", UDOB.Value.Date);
                cmd.Parameters.AddWithValue("@UNUM", UNumberTB.Text);
                cmd.Parameters.AddWithValue("@UP", UPasswordTB.Text);
                cmd.Parameters.AddWithValue("@UA", UAddressTB.Text);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" updated successfully!");
                con.Close();
                ShowUser();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Retrieves the values from the UserTbl table for the specified ID
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UName, UDOB, UNum, UPass, UAddress FROM UserTbl WHERE UId=@ID", con);
                int IDZ = Convert.ToInt32(SelectedID.Text);
                cmd.Parameters.AddWithValue("@ID", IDZ);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UNameTB.Text = reader["UName"].ToString();
                    UPasswordTB.Text = reader["UPass"].ToString();
                    UDOB.Value = Convert.ToDateTime(reader["UDOB"]);
                    UAddressTB.Text = reader["UAddress"].ToString();
                    UNumberTB.Text = reader["UNum"].ToString();
                }
                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Values");
                con.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            adminexpenses ae = new adminexpenses();
            ae.Show();
        }
    }
}

