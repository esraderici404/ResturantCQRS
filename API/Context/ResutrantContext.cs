using API.Dal;
using Cqrs_dal.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.Context
{
    public class ResutrantContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-J1MPADH\\SABRI; database=CRQSResturant;integrated security=true");
        }


        public DbSet<Food> Foods { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Service> Services { get; set; }


    }
}
