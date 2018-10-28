using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FatClub.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FatClub.Pages
{
    public class UserInfoModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public UserInfoModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string UserId { get; set; }

        public List<Measurement> UserMeasurements { get; set; }
        public ApplicationUser User { get; set; }
        public void OnGet()
        {
            User = _context.Users.FirstOrDefault(x => x.Id == UserId);
            UserMeasurements = _context.Measurement.Include(x => x.User).Where(x => x.User.Id == UserId).OrderByDescending(x => x.MeasureDate).ToList();
        }
    }
}