using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController(IProfileRepository service) : ControllerBase
    {
        private readonly IProfileRepository _service = service;
        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var usersWithProfile = await _service.GetAll();

            return Ok(usersWithProfile);
        }
    }
}