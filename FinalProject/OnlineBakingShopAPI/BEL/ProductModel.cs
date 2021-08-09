using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int TypeId { get; set; }
        public string ProductDetail { get; set; }
        public string Picture { get; set; }
        public int FlavourId { get; set; }
        public string Category { get; set; }

        public string MenuName { get; set; }
        public string TypeName { get; set; }
    }
}