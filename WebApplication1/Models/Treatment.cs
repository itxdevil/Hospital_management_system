using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Treatment
    {
        public int patient_id { get; set; }
        public string disease { get; set; }
        public string prescription { get; set; }
        public string medicines { get; set; }

        public void Insert(Treatment Tr)
        {
            string query = string.Format("insert into prescription values('{0}', '{1}', '{2}', '{3}')",Tr.patient_id,Tr.disease,Tr.prescription,Tr.medicines);
            SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
            cmd.ExecuteNonQuery();
        }
    }
}