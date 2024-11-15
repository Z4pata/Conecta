using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conecta.DTOs.Requests
{
    public class ProfileRequest
    {
        public string? ImageUrl { get; set; }
        public string? Biography { get; set; }
        public string? OtherDetails { get; set; }
    }
}