using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using catStoreTest.Models;
using Newtonsoft.Json;

namespace catStoreTest.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            //string allText = System.IO.File.ReadAllText(@"D:\Java\CatStore\CatStore\App_Data\data.json");
            //var serializer = new JavaScriptSerializer();
            //dynamic result = serializer.Deserialize<dynamic>(allText);

            string requestUrl = "http://cat-store-api.frostdigital.se/api";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);

            //Response coming
            HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
            // var resstream = responce.GetResponseStream();
            Stream responseStream = responce.GetResponseStream();

            StreamReader responseReader = new System.IO.StreamReader(responseStream, Encoding.UTF8);

            var js = new JsonSerializer();

            var objText = responseReader.ReadToEnd();

            RootObject result = JsonConvert.DeserializeObject<RootObject>(objText); //js.Deserialize<RootObject>(objText);

            Product[] products = new Product[]
            {
                new Product
                {
                    Code = 1,
                    Name = result.products[0].Name,
                    Description = result.products[0].Description,
                    ImgURL = result.products[0].ImgURL,
                    Price = 500,
                    IsAvaiable = true,
                    Stock = result.products[0].Stock
                },
                new Product
                {
                    Code = 2,
                    Name = result.products[1].Name,
                    Description = result.products[1].Description,
                    ImgURL = result.products[1].ImgURL,
                     Price = 4000,
                    IsAvaiable = true,
                    Stock = result.products[1].Stock
                },
                new Product
                {
                    Code = 3,
                    Name = result.products[2].Name,
                    Description = result.products[2].Description,
                    ImgURL = result.products[2].ImgURL,
                     Price = 1500,
                    IsAvaiable = true,
                    Stock = result.products[2].Stock
                },
                new Product
                {
                    Code = 4,
                    Name = result.products[3].Name,
                    Description = result.products[3].Description,
                    ImgURL = result.products[3].ImgURL,
                    Price = 1000,
                    IsAvaiable = true,
                    Stock = result.products[3].Stock
                }
            };

            return products;
        }


        [HttpGet]
        public IHttpActionResult GetProduct(string name)
        {

            //string allText = System.IO.File.ReadAllText(@"D:\Java\CatStore\CatStore\App_Data\data.json");
            //var serializer = new JavaScriptSerializer();
            //dynamic result = serializer.Deserialize<dynamic>(allText);

            string requestUrl = "http://cat-store-api.frostdigital.se/api";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);

            //Response coming
            HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
            // var resstream = responce.GetResponseStream();
            Stream responseStream = responce.GetResponseStream();

            StreamReader responseReader = new System.IO.StreamReader(responseStream, Encoding.UTF8);

            var js = new JsonSerializer();

            var objText = responseReader.ReadToEnd();

            RootObject result = JsonConvert.DeserializeObject<RootObject>(objText); //js.Deserialize<RootObject>(objText);

            Product[] products = new Product[]
            {
                new Product
                {
                    Code = 1,
                    Name = result.products[0].Name,
                    Description = result.products[0].Description,
                    ImgURL = result.products[0].ImgURL,
                    Price = 500,
                    IsAvaiable = true,
                    Stock = result.products[0].Stock
                },
                new Product
                {
                    Code = 2,
                    Name = result.products[1].Name,
                    Description = result.products[1].Description,
                    ImgURL = result.products[1].ImgURL,
                     Price = 4000,
                    IsAvaiable = true,
                    Stock = result.products[1].Stock
                },
                new Product
                {
                    Code = 3,
                    Name = result.products[2].Name,
                    Description = result.products[2].Description,
                    ImgURL = result.products[2].ImgURL,
                     Price = 1500,
                    IsAvaiable = true,
                    Stock = result.products[2].Stock
                },
                new Product
                {
                    Code = 4,
                    Name = result.products[3].Name,
                    Description = result.products[3].Description,
                    ImgURL = result.products[3].ImgURL,
                    Price = 1000,
                    IsAvaiable = true,
                    Stock = result.products[3].Stock
                }

            };

            var product = from c in products
                          where products.Any(i => c.Name.Contains(name.Trim()))
                          select c;

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //[Route("api/{controller}/{id}")]
        [HttpGet]
        public IHttpActionResult GetProduct(int? id)
        {

            //string allText = System.IO.File.ReadAllText(@"D:\Java\CatStore\CatStore\App_Data\data.json");
            //var serializer = new JavaScriptSerializer();
            //dynamic result = serializer.Deserialize<dynamic>(allText);

            string requestUrl = "http://cat-store-api.frostdigital.se/api";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);

            //Response coming
            HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
            // var resstream = responce.GetResponseStream();
            Stream responseStream = responce.GetResponseStream();

            StreamReader responseReader = new System.IO.StreamReader(responseStream, Encoding.UTF8);

            var js = new JsonSerializer();

            var objText = responseReader.ReadToEnd();

            RootObject result = JsonConvert.DeserializeObject<RootObject>(objText); //js.Deserialize<RootObject>(objText);

            Product[] products = new Product[]
            {
                new Product
                {
                    Code = 1,
                    Name = result.products[0].Name,
                    Description = result.products[0].Description,
                    ImgURL = result.products[0].ImgURL,
                    Price = 500,
                    IsAvaiable = true,
                    Stock = result.products[0].Stock
                },
                new Product
                {
                    Code = 2,
                    Name = result.products[1].Name,
                    Description = result.products[1].Description,
                    ImgURL = result.products[1].ImgURL,
                     Price = 4000,
                    IsAvaiable = true,
                    Stock = result.products[1].Stock
                },
                new Product
                {
                    Code = 3,
                    Name = result.products[2].Name,
                    Description = result.products[2].Description,
                    ImgURL = result.products[2].ImgURL,
                     Price = 1500,
                    IsAvaiable = true,
                    Stock = result.products[2].Stock
                },
                new Product
                {
                    Code = 4,
                    Name = result.products[3].Name,
                    Description = result.products[3].Description,
                    ImgURL = result.products[3].ImgURL,
                    Price = 1000,
                    IsAvaiable = true,
                    Stock = result.products[3].Stock
                }

            };

            var product = products.FirstOrDefault((p) => p.Code == id);

            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }

}
