using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class SchoolContext: DbContext
    {   //enables CRUD functionality
        public DbSet<Student> Students { get; set; }
    }
}