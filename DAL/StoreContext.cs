using DAL.Models;
using DAL.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffEmail> StaffEmails { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsInDepartment> productsInDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server = localhost; Database = StoreKim; Trusted_Connection = True") ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Staff>()
                .HasOne<Staff>(s => s.Mentor)
                .WithMany(s => s.Staffs)
                .HasForeignKey(s => s.MentorID);

            modelBuilder.Entity<StaffEmail>().HasKey(se => se.EmailID);

            modelBuilder.Entity<StaffEmail>()
                .HasOne<Staff>(se => se.Staff)
                .WithMany(s => s.Emails)
                .HasForeignKey(se => se.StaffID);

            modelBuilder.Entity<Department>()
                .HasOne<Staff>(d => d.Staff)
                .WithMany(s => s.Departments)
                .HasForeignKey(d => d.StaffID);

            modelBuilder.Entity<Product>()
                .HasOne<Campaign>(p => p.Campaign)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CampaignID);

            modelBuilder.Entity<Product>()
                .HasOne<Staff>(p => p.Staff)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.StaffID);

            modelBuilder.Entity<ProductsInDepartment>()
                .HasKey(pd => new { pd.ProductID, pd.DepartmentID });

            modelBuilder.Entity<ProductsInDepartment>()
                .HasOne<Product>(pd => pd.Product)
                .WithMany(p => p.ProductDepartment)
                .HasForeignKey(pd => pd.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductsInDepartment>()
                .HasOne<Department>(pd => pd.Department)
                .WithMany(d => d.ProductDepartment)
                .HasForeignKey(pd => pd.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Staff>().HasIndex(s => s.PersonalNumber).IsUnique();


            StaffSeed.StaffSeeder(modelBuilder);
            StaffEmailSeed.StaffEmailSeeder(modelBuilder);
            DepartmentSeed.DepartmentSeeder(modelBuilder);
            CampaignSeed.CampaignSeeder(modelBuilder);
            ProductSeed.ProductSeeder(modelBuilder);
            ProductsInDepartmentSeed.ProductsInDepartmentSeeder(modelBuilder);
        } 
    }
}
