using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class CourierModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public string NID { get; set; }
        public bool Registered { get; set; }
        public bool Availability { get; set; }
    }
}