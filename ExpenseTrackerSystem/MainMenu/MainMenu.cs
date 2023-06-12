using BudgetBuddy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTrackerSystem
{
    public partial class mainmem : Form
    {
        public mainmem()
        {
            InitializeComponent();
            addexpense1.Hide();
            usrLBL.Text = Login.User + "!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // view expenses 
            this.Close();
            ViewExpenses viewex = new ViewExpenses();
            viewex.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addexpense1.Show();
            addexpense1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
            //System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            report rep = new report();
            rep.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
