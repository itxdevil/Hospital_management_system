using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Patient
    {
        public string Patient_id { get; set; }
        public int Patient_name { get; set; }
        public string Patient_address { get; set; }
        public string Patient_phone_number { get; set; }
        public string Patient_age { get; set; }
        public string Patient_gender { get; set; }
        public string Patient_blood_group { get; set; }
        public string Major_disease { get; set; }
        public string Doctor_Id { get; set; }

        public void Insert(Patient p)
        {
            string query = string.Format("insert into Patient values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}, '{7})", p.Patient_id,p.Patient_name,p.Patient_address,p.Patient_phone_number,p.Patient_age,p.Patient_gender,p.Patient_blood_group,p.Major_disease,p.Doctor_Id);
            SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
            cmd.ExecuteNonQuery();
        }
    }
}