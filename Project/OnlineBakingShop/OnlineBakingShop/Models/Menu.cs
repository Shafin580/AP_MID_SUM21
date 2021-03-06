//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBakingShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }

        [Display(Name = "Flavour")]

        [Required(ErrorMessage = "Please put Flavour Name")]
        public string FlavourName { get; set; }

        [Display(Name = "Details")]

        [Required(ErrorMessage = "Please put Description")]
        public string FlavourDetail { get; set; }

        [Required(ErrorMessage = "Please put Price")]
        public double Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
