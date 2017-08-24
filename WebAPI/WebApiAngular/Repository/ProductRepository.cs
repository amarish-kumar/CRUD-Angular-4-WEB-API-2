using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngular.Context;
using WebApiAngular.Models.Entities;
using WebApiAngular.Models.Exceptions;

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
            try
            {
                return Context.Products;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
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
                throw new RepositoryException(ex.Message, ex);
            }  
        }

        //Put product
        public void UpdateProduct(Product product)
        {

            try
            {
                Context.Entry(product).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
            
        }

        //GET product
        public Product GetProduct(int id)
        {
            try
            {
                Product product = GetProductById(id);
                return product;
                
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //DELETE product
        public Product DeleteProduct(int id)
        {
            try
            {             
                Product product = GetProductById(id);

                if (product != null)
                {               
                    Context.Products.Remove(product);
                    Context.SaveChanges();
                }
            
                return product;

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


        private Product GetProductById(int id)
        {
            try
            {               
                Product product = Context.Products.Find(id);
                return product;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


    
    }
}