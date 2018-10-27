using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FatClub.Data
{
    public class Measurement 
    {
        [Key]
        public int Id { get; set; }

        public IdentityUser User { get; set; }
        public double Weight { get; set; }
        public DateTime MeasureDate { get; set; }
    }
}
