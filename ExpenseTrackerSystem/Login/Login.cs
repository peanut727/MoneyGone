
using BudgetBuddy;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseTrackerSystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
            about1.Hide();
            splash1.Show();
            splash1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlogin ad = new adminlogin();
            ad.Show();
        }

        // Power Button "for exxiting the application"
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // to show the user on the main menu
        public static string User;
        private void loginbt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("select count(*) from UserTbl where UName='" + UNameTB.Text + "' and UPass='" + UPassTB.Text + "'", con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                User = UNameTB.Text;
                mainmem menu = new mainmem();
                menu.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Credential!");
            }
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            splash1.Hide();
            about1.Show();
            about1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            splash1.Hide();
            about1.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersignup signup = new usersignup();
            signup.Show();
        }


    }
}
