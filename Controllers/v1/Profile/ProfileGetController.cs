using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1.Profile
{
    public partial class ProfileController
    {
        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var usersWithProfile = await _service.GetAll();

            return Ok(usersWithProfile);
        }
    }
}