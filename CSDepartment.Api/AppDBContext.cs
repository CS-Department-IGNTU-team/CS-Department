using CSDepartment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        /// Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Name = "Admin",
                    Role = "Administrator",
                    Username = "admin",
                    Password = "4321",
                    Email = "prabhakarishu5695@gmail.com",
                    Rights = new Rights() { CanDelete = true, CanModify = true, CanPost = true, CanWrite = true },
                });
        }
    }
}
