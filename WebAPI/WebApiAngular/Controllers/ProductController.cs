using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngular.Context;
using WebApiAngular.Models.Entities;
using WebApiAngular.Models.Exceptions;
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
        [ResponseType(typeof(Product[]))]
        public IHttpActionResult GetProduct()
        {
            try
            {
                return Ok(ProductService.getProducts());
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);                
            }           
        }

        // POST: api/Product
        [ResponseType(typeof(Product))]     
        public IHttpActionResult PostProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                ProductService.PostProduct(product);

                return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);                
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);                
            }
        }

        // PUT: api/Product/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult PutProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                        
                ProductService.UpdateProduct(product);

                return Ok(product);               
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }
        }
        

        // GET: api/Product/:id
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            try
            {
                Product product = ProductService.GetProduct(id);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);              
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }
        }

        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            try
            {
                Product product = ProductService.DeleteProduct(id);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }           
        }
    }
}
