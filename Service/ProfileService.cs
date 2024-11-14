using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Data;
using Conecta.Models;
using Conecta.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Conecta.Service
{
    public class ProfileService(AppDbContext context) : IProfileRepository
    {
        private readonly AppDbContext _context = context;
        public async Task<ICollection<User>> GetAll()
        {
            var users = await _context.Users.Include(u => u.Profile).ToListAsync();

            return users;
        }
    }
}