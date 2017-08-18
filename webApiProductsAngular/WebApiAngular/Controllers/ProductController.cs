using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngular.Context;
using WebApiAngular.Models;
using WebApiAngular.Services;

namespace WebApiAngular.Controllers
{    
    public class ProductController : ApiController
    {
        public ProductService ProductService;
        public ProductController()
        {
            ProductService = new ProductService();
        }

        // GET: api/Products
        public IQueryable<Product> GetProduct()
        {
            return ProductService.getProducts();
        }

        // POST: api/Product
        [ResponseType(typeof(Product))]     
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ProductService.PostProduct(product);

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // GET: api/Product/:id
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            
            Product product = ProductService.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product); 
        }

        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = ProductService.DeleteProduct(id);
            
            if (product == null)
            {
                return NotFound();
            }
            
            return Ok(product);
        }


    }
}
