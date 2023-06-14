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
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Linq.Expressions;

namespace BudgetBuddy
{

    public partial class report : Form
    {
        SqlConnection con = DBConnection.GetConnection();
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
            string value = dt.Rows[0][0].ToString();
            decimal moneyval;

            if (Decimal.TryParse(value, out moneyval))
            {
                MaxLbl.Text = moneyval.ToString("C");
            }
            con.Close();
        }
        private void GetMinExp()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string value = dt.Rows[0][0].ToString();
            decimal moneyval;

            if (Decimal.TryParse(value, out moneyval))
            {
                MinLbl.Text = moneyval.ToString("C");
            }
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

                decimal total = 0;
                int count = 0;

                if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
                {
                    decimal.TryParse(dt.Rows[0][0].ToString(), out total);
                    int.TryParse(dt1.Rows[0][0].ToString(), out count);
                }

                decimal avg = count > 0 ? total / count : 0;
                AvgLbl.Text = avg.ToString("C");
                CountLbl.Text = count.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }
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
                TotalLbl.Text = moneyval.ToString("C");
            }
            con.Close();
        }
        private void GetTotExpCat()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser='" + Login.User + "' and ExpCat='"+expCateg.SelectedItem.ToString()+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string value = dt.Rows[0][0].ToString();
            decimal moneyval;

            if (Decimal.TryParse(value, out moneyval))
            {
                APCount.Text = moneyval.ToString("C");
                APCount.Visible = true;
            }
            else
            {
                APCount.Text = "";
            }
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