using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FatClub.Data
{
    public class Measurement 
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser User { get; set; }
        [Range(30.0, 200.0)]
        public double Weight { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeasureDate { get; set; }
    }
}
