using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngular.Context;
using WebApiAngular.Models;

namespace WebApiAngular.Repository
{
    public class ProductRepository
    {                
        private EFContext Context;

        public ProductRepository()
        {
            Context = EFContext.ContextFactory();
        }

        //Get all products
        public IQueryable<Product> GetProducts()
        {
            return Context.Products;
        }

        //Post product
        public void PostProduct(Product product)
        {
            try
            {
                Context.Products.Add(product);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }  

        }

        //Put product
        public void UpdateProduct(Product product)
        {
           
            Context.Entry(product).State = EntityState.Modified;

            Context.SaveChanges();
           
        }

        //GET product
        public Product GetProduct(int id)
        {
            Product product = GetProductById(id);
            return product;
        }

        //DELETE product
        public Product DeleteProduct(int id)
        {
            Product product = GetProductById(id);

            if (product != null)
            {               
                Context.Products.Remove(product);
                Context.SaveChanges();
            }
            
            return product;
        }


        private Product GetProductById(int id)
        {
            Product product = Context.Products.Find(id);
            return product;
        }
    
    }
}