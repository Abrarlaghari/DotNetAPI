
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entities;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<BlogPost> blogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
  
            modelBuilder.Entity<BlogPost>()
                .HasKey(e => e.Id);
         
        }



    }
}
