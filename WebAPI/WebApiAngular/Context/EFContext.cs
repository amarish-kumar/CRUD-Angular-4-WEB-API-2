using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApiAngular.Models;

namespace WebApiAngular.Context
{
    public class EFContext : DbContext
    {
        //Criar um factory para contexto, assim com ta no email

        public EFContext() : base("WEBAPI-ANGULAR")
        {
        }
        
        public virtual DbSet<Product> Products { get; set; }
        
        //Factpry para contexto
        public static EFContext ContextFactory()
        {            
            return new EFContext();
        }
    }
}