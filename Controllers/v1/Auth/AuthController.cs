using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Config;
using Conecta.DTOs.Requests;
using Conecta.Repositories;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IUserRepository service) : ControllerBase
    {
        private readonly IUserRepository _service = service;

        [HttpPost]
        public async Task<IActionResult> Login (LoginRequestDTO request)
        {
            var user = await _service.GetByEmail(request.Email);

            if (user == null)
            {
                return NotFound("User by that credentials Not found");
            }

            if (!_service.CheckPassword(request.Password, user))
            {
                return BadRequest("Incorrect credentials");
            }

            var token = JWT.GenerateJwtToken(user);

            return Ok($"Logeado con exito, su token es: {token}");
        }


    }
}