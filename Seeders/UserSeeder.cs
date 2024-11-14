using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using Conecta.Models;
using Microsoft.EntityFrameworkCore;

namespace Conecta.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Name = "Juan Jose", Email = "zapata.devs@gmail.com", Password = BCrypt.Net.BCrypt.HashPassword("password"), RoleId = 1, CreationDate = DateTime.Now},
                new User {Id = 2, Name = "Test", Email = "user@example.com", Password = BCrypt.Net.BCrypt.HashPassword("string"), RoleId = 2, CreationDate = DateTime.Now}
            );
        }
    }
}