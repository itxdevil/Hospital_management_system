using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public string Doctor_Name { get; set; }
        public int Doctor_Id { get; set; }
        public string Doctor_Experience { get; set; }
        public string Doctor_Password { get; set; }
        public string Doctor_Age { get; set; }
        public string Doctor_Room_Number { get; set; }

        public void Insert(Doctor d)
        {
            string query = string.Format("insert into Add_Doctor values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", d.Doctor_Name,d.Doctor_Id,d.Doctor_Experience,d.Doctor_Password,d.Doctor_Age,d.Doctor_Room_Number);
            SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
            cmd.ExecuteNonQuery();
        }
        public void Delete(int Id)
        {
            string query = string.Format("delete from Add_Doctor where ID = {0}", Id);
            SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
            cmd.ExecuteNonQuery();
        }
        public List<Doctor> Select()
        {
            string query = string.Format("select * from Add_Doctor");
            SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
            SqlDataReader read = cmd.ExecuteReader();
            List<Doctor> BD = new List<Doctor>();
            while (read.Read())
            {
                Doctor D = new Doctor();
                D.Doctor_Name = read[0].ToString();
                D.Doctor_Id = int.Parse(read[1].ToString());
                D.Doctor_Experience = read[2].ToString();
                D.Doctor_Password= read[3].ToString();
                D.Doctor_Age = read[4].ToString();
                D.Doctor_Room_Number = read[5].ToString();
                BD.Add(D);
            }
            read.Close();
            return BD;
        }
    }
}
