using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace BudgetBuddy
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Public\Desktop\ExpenseDB.mdf;MultipleActiveResultSets=True;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
