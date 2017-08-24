using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApiAngular.Models.Entities;

namespace WebApiAngular.Context
{
    public class EFContext : DbContext
    {        
        public EFContext() : base("WEBAPI-ANGULAR")
        {
        }
        
        public virtual DbSet<Product> Products { get; set; }
        
        //Factory para contexto
        public static EFContext ContextFactory()
        {            
            return new EFContext();
        }
    }
}