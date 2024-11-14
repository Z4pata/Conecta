using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Models;

namespace Conecta.Repositories
{
    public interface IProfileRepository
    {
        Task<ICollection<User>> GetAll();
    }
}