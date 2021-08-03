using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderDetail
    {
        public int id { get; set; }
        public string pname { get; set; }
        public string qty { get; set; }
        public decimal totalprice { get; set; }
    }
}
