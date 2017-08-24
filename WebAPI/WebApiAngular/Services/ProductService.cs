using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAngular.Models.Entities;
using WebApiAngular.Models.Exceptions;
using WebApiAngular.Repository;

namespace WebApiAngular.Services
{
    public class ProductService
    {
        private ProductRepository ProductRepository;

        public ProductService()
        {
            ProductRepository = new ProductRepository();
        }

        //GET all products
        public IQueryable<Product> getProducts()
        {
            try
            {             
                 return ProductRepository.GetProducts();
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }
        

        //ADD product
        public void PostProduct(Product product)
        {
            try
            {                
                ProductRepository.PostProduct(product);             
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //UPDATE product
        public void UpdateProduct(Product product)
        {
            try
            {
                ProductRepository.UpdateProduct(product);                
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //GET product
        public Product GetProduct(int id)
        {
            try
            {
                return ProductRepository.GetProduct(id);               
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //DELETE product
        public Product DeleteProduct(int id)
        {
            try
            {
                return ProductRepository.DeleteProduct(id);                   
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


    }
}