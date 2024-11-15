using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.DTOs.Requests;
using Conecta.Models;

namespace Conecta.Repositories
{
    public interface IProfileRepository
    {
        Task<ICollection<User>> GetAll();
        Task<Profile?> GetByid(int id);
        Task Update(Profile profileToUpdate, ProfileRequest Data);
    }
}