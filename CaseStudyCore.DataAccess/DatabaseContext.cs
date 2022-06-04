using CaseStudyCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.DataAccess
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=casestudydb; integrated security=true;");
        }

        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
