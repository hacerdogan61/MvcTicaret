using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrganikTicaret.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
        
        }
       public DbSet<Products> pro { get; set; }
       public DbSet<Category> cat  {get; set;}

    }
}