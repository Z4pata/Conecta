using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Models;
using Microsoft.EntityFrameworkCore;

namespace Conecta.Seeders
{
    public class ProfileSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile {UserId = 1, Biography = "Naci en bello en el 2007", OtherDetails = "Quiero estudiar ingenieria de sistemas"},
                new Profile {UserId = 2, Biography = "Naci en Chicago en el 2000", OtherDetails = "Quiero estudiar Inteligencia artificial"}
            );
        }
    }
}