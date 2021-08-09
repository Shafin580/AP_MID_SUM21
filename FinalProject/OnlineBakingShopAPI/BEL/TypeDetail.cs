using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEL
{
    public class TypeDetail
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}