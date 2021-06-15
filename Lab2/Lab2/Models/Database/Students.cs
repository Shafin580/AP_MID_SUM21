using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Lab2.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            //string query = String.Format("Insert into Student values ('{0}','{1}',{2},{3},{4},{5})", s.Name, s.Id, s.DOB, s.Credit, s.Cgpa, s.DepartmentName);
            string query = "Insert into Student values(@name,@student_id,@dob,@credit,@cgpa,@department_name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@student_id", s.Id);
            cmd.Parameters.AddWithValue("@dob", s.DOB);
            cmd.Parameters.AddWithValue("@credit", s.Credit);
            cmd.Parameters.AddWithValue("@cgpa", s.Cgpa);
            cmd.Parameters.AddWithValue("@department_name", s.DepartmentName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> Students = new List<Student>();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Name = reader.GetString(reader.GetOrdinal("name")),
                    Id = reader.GetString(reader.GetOrdinal("student_id")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("credit")),
                    Cgpa = reader.GetDouble(reader.GetOrdinal("cgpa")),
                    DepartmentName = reader.GetString(reader.GetOrdinal("department_name")),
                };
                Students.Add(s);
            }
            conn.Close();
            return Students;
        }
        public Student Get(string id)
        {
            Student s = null;
            string query = $"select * from Student Where student_id='{id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    Name = reader.GetString(reader.GetOrdinal("name")),
                    Id = reader.GetString(reader.GetOrdinal("student_id")),
                    DOB = reader.GetDateTime(reader.GetOrdinal("dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("credit")),
                    Cgpa = reader.GetDouble(reader.GetOrdinal("cgpa")),
                    DepartmentName = reader.GetString(reader.GetOrdinal("department_name")),
                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student s)
        {
            string query = $"Update Student Set name='{s.Name}', cgpa={s.Cgpa} ,credit={s.Credit}, department_name='{s.DepartmentName}', dob='{s.DOB}' Where student_id = '{s.Id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(string id)
        {
            string query = $"DELETE FROM Student WHERE student_id = '{id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}