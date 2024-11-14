using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Conecta.Seeders
{
    public class RoleSeeder : ModelBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role {Id = 1, Name = "admin", CreationDate = DateTime.Now, UpdateDate = null},
                new Role {Id = 2, Name = "user", CreationDate = DateTime.Now, UpdateDate = null}

            );
        }
    }
}