using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Lab2.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        
        public Database()
        {
            string connString = @"Server=SHAFIN\SQLEXPRESS;Database=lab2;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);
            
            

        }
    }
}