using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conecta.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Conecta.Controllers.v1.Profile
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class ProfileController(IProfileRepository service) : ControllerBase
    {
        private readonly IProfileRepository _service = service;
        
    }
}