using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<Customer_ProducteModel> custumer_model { get; set; }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BranchModel>().Property(b => b.Area).IsRequired();

            // seeding 
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { ID = 1, Address = "Riyadh", Area = "Al-rayan", Name = "branch01" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { ID = 2, Address = "Riyadh", Area = "Al-rayan", Name = "branch02" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { ID = 3, Address = "Riyadh", Area = "Al-rayan", Name = "branch03" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel { ID = 4, Address = "Riyadh", Area = "Al-rayan", Name = "branch04" });

            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 1, FirstName = "Ahmad", LastName = "Alqhtani", Email = "xxxxxxx@xxxx.xxx" });
            modelBuilder.Entity<CustomerModel>().HasData(new CustomerModel { id = 2, FirstName = "Abdualla", LastName = "Alqhtani", Email = "xxxxxxx@xxxx.xxx" });

        }

    }



}

