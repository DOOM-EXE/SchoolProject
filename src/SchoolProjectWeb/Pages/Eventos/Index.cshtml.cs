using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolProjectWeb.Data;
using SchoolProjectWeb.Models;

namespace SchoolProjectWeb.Pages_Eventos
{
    public class IndexModel : PageModel
    {
        private readonly SchoolProjectWeb.Data.ApplicationDbContext _context;

        public IndexModel(SchoolProjectWeb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Evento> Evento { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Evento = await _context.Eventos
                .Include(e => e.Actividad).ToListAsync();
        }
    }
}
