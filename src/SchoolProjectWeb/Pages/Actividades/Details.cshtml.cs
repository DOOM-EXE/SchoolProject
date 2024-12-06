using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;

namespace SchoolProjectWeb.Pages_Actividades
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolProjectWeb.Data.ApplicationDbContext _context;

        public DetailsModel(SchoolProjectWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Actividad Actividad { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades.FirstOrDefaultAsync(m => m.Id == id);

            if (actividad is not null)
            {
                Actividad = actividad;

                return Page();
            }

            return NotFound();
        }
    }
}
