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

    public partial class Login
    {
        public int LoginId { get; set; }

        [Display(Name = "Username")]
        public string LoginUsername { get; set; }

        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
        public string UserType { get; set; }
    }
}
