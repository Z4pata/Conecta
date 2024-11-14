using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Models;
using Conecta.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Conecta.Data
{
    public class AppDbContext : DbContext
    {
        public required DbSet<Role> Roles { get; set; }
        public required DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            RoleSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
        }
    }
}