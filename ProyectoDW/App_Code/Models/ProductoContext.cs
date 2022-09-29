using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoDW.App_Code.Models
{
    public class ProductoContext
    {
        public ProductoContext()
        {

        }

        public DbSet<ClsCarritoCompra> ShoppingIngCartItems { get; set; }
        
    }
}