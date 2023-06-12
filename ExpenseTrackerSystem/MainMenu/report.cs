using ExpenseTrackerSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.sqldata;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Linq.Expressions;

namespace BudgetBuddy
{

    public partial class report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        public report()
        {
            InitializeComponent();
            GetMaxExp();
            GetMinExp();
            GetTotExp();
            GetAvgExp();
            GetBestCat();
            GetLowCat();
        }


        private void GetMaxExp()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select MAx(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MaxLbl.Text = "PHP" + dt.Rows[0][0].ToString();
            con.Close();
        }
        private void GetMinExp()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MinLbl.Text = "PHP" + dt.Rows[0][0].ToString();
            con.Close();
        }
        private void GetAvgExp()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
                SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                sda.Fill(dt);
                sda1.Fill(dt1);
                double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
                AvgLbl.Text = "PHP" + Avg;
                CountLbl.Text = dt1.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void GetTotExp()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalLbl.Text = "PHP" + dt.Rows[0][0].ToString();
            con.Close();
        }
        private void GetTotExpCat()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "' and ExpCat='"+expCateg.SelectedItem.ToString()+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            APCount.Text = "PHP" + dt.Rows[0][0].ToString();
            APCount.Visible = true;
            con.Close();
        }

        private void GetBestCat()
        {
            con.Open();
            string InnerQuery = "select Max(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
            sda1.Fill(dt1);
            string query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HighLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void GetLowCat()
        {
            con.Open();
            string InnerQuery = "select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
            sda1.Fill(dt1);
            string query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LowLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmem menu = new mainmem();
            menu.Show();
        }

        private void expCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotExpCat();
        }
    }
}