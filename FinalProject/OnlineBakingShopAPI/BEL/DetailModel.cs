using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class DetailModel
    {
        public int Id { get; set; }
        public Nullable<int> CourierId { get; set; }
        public int TransactionId { get; set; }

        public string CourierName { get; set; }
        public string TransactionName { get; set; }
    }
}