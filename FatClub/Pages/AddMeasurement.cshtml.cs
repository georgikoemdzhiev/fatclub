using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FatClub.Data;
using Microsoft.AspNetCore.Identity;

namespace FatClub.Pages
{
    public class AddMeasurementModel : PageModel
    {
        private readonly FatClub.Data.ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AddMeasurementModel(FatClub.Data.ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Measurement Measurement { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // set the current user
            Measurement.User = await _userManager.GetUserAsync(User);
            _context.Measurement.Add(Measurement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}