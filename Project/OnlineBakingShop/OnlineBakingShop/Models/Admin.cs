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

    public partial class Admin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please put Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please put Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please put Email")]

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please put Password")]
        public string Password { get; set; }
    }
}
