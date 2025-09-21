using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab11.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}