using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Home
    {
        public string username{get ; set;}
        public string password { get; set; }

        public void Insert(Home ts)
        {
            string query = string.Format("insert into test values('{0}', '{1}')",ts.username,ts.password);
            SqlCommand cmd = new SqlCommand(query,Connection.GetCon());
            cmd.ExecuteNonQuery();
        }
    }
}