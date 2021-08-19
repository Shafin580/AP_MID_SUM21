using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int TypeId { get; set; }
        public string ProductDetail { get; set; }
        public string Picture { get; set; }
        public int FlavourId { get; set; }
        public string Category { get; set; }

        public virtual MenuModel Menu { get; set; }
        public virtual TypeModel Type { get; set; }

        public ICollection<TransactionModel> Transactions { get; set; }
    }
}