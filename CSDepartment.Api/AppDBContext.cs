using CSDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api
{
    public class AppDBContext : DbContext
    {
        //public string GetConnectionString()
        //{
        //    return Directory.GetCurrentDirectory() + "/Demo/DB/devDB.db";
        //}

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SQLitePCL.Batteries.Init();
        }

        /// Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Post>()
                .HasKey(p => new { p.Title, p.Timestamp });

            modelBuilder.Entity<Media>()
                .HasKey(m => new { m.Name, m.Timestamp });

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Name = "Admin",
                    Role = "Administrator",
                    Username = "admin",
                    Password = "4321",
                    Email = "mrunpredictable3679@gmail.com",
                });
        }
    }
}
