using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly EmailService _emailService;

        public EmailController()
        {
            _emailService = new EmailService();
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            await _emailService.SendEmailAsync(request.ToEmail, request.Subject, request.Message);
            return Ok(new { message = "Email sent successfully" });
        }
    }
}