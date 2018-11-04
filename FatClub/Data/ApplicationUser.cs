using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FatClub.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public double Weight { get; set; } = 0.0;
        public double Height { get; set; } = 0.0;
    }
}