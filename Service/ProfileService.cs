using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Data;
using Conecta.DTOs.Requests;
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

        public async Task<Profile?> GetByid(int id)
        {
            var profile = await _context.Profiles.FirstOrDefaultAsync(p => p.UserId == id);

            return profile;
        }

        public async Task Update(Profile profileToUpdate, ProfileRequest ChangeData)
        {
            _context.Entry(profileToUpdate).CurrentValues.SetValues(ChangeData);

            await _context.SaveChangesAsync();
        }
    }
}