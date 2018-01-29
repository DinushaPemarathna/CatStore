using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace catStoreTest.Models
{
    [JsonObject]
    public class Product
    {
        [Key]
        public int Code { get; set; }

        //[JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("imageUrl")]
        public string ImgURL { get; set; }

        //[JsonProperty("stock")]
        public int Stock { get; set; }
        public bool IsAvaiable { get; set; }


        //Price for the product (not included in API response, decide on a value for each item).
        public decimal Price { get; set; }
    }
}