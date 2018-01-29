using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catStoreTest.Models
{
    [Bind(Exclude = "OrderId")]
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        [ScaffoldColumn(false)]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}