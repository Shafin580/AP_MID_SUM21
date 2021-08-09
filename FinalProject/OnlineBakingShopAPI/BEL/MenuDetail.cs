using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class MenuDetail
    {
        public int Id { get; set; }
        public string FlavourName { get; set; }
        public string FlavourDetail { get; set; }
        public double Price { get; set; }

        public ICollection<ProductModel> Products { get; set; }
    }
}