using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Connection
    {
        public static SqlConnection con;
        public static SqlConnection GetCon()
        {
            if (con == null)
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=AFNAN-PC\SQLEXPRESS;Initial Catalog=Hospital_management_system;Integrated Security=True";
                con.Open();
            }
            return con;
        }

    }
}
