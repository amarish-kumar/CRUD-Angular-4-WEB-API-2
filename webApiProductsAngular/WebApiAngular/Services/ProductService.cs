using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAngular.Models;
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
            return ProductRepository.GetProducts();
        }
        
        //POST product
        public void PostProduct(Product product)
        {
            ProductRepository.PostProduct(product);
        }

        public Product GetProduct(int id)
        {
            return ProductRepository.GetProduct(id);
        }

        public Product DeleteProduct(int id)
        {
            return ProductRepository.DeleteProduct(id);
        }


    }
}