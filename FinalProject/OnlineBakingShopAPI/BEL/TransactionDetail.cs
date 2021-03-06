using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string DeliveryLocation { get; set; }
        public long CustomerContactNumber { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int ProductId { get; set; }
        public int ProductQty { get; set; }
        public double DeliveryCharge { get; set; }
        public double AdvancePaid { get; set; }
        public double TotalPrice { get; set; }
        public int DeliveryStatus { get; set; }
        public Nullable<long> TransactionNumber { get; set; }

        public virtual ProductModel Product { get; set; }

        public ICollection<DetailModel> Details { get; set; }
    }
}