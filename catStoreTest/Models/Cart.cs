using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catStoreTest.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        //public virtual Product Product { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        //Price for the product (not included in API response, decide on a value for each item).
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public bool IsAvaiable { get; set; }
    }
}