using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Conecta.DTOs.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1.Profile
{
    public partial class ProfileController
    {
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(ProfileRequest profileRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userIdClaim = Convert.ToInt16(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var profile = await _service.GetByid(userIdClaim);

            if (profile == null)
            {
                return NotFound("Profile not foud");
            }

            try
            {

                await _service.Update(profile, profileRequest);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Ok("Profile updated");
        }
    }
}