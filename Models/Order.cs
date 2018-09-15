using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage="Please enter your first name and last name")]
        public string Name { get; set; }

        [Required(ErrorMessage="Please enter your address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage="Please enter your city")]
        public string City { get; set; }
        
        [Required(ErrorMessage="Please enter your state")]
        public string State { get; set; }

        [Required(ErrorMessage="Please enter your zip code")]
        public string Zip { get; set; }

        [Required(ErrorMessage="Please enter your country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

    }
}