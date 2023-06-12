using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BudgetBuddy.sqldata
{
   

    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\ExpenseDB.mdf;Integrated Security=True;Connect Timeout=30");
            return con;
        }
    }
}
