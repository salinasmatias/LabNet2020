using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Capas.MVC.Models
{
    public class ShipperView
    {
        public int ShipperID { get; set; }
        
        [StringLength(60, MinimumLength =3)]
        [Required(ErrorMessage = "Enter Name (Must have at least 3 characters and up to 60.")]
        public string CompanyName { get; set; }
        
        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Enter Phone (Must start with (503).)")]
        public string Phone { get; set; }

    }
}