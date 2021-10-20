using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExercicioAutoEscola.Data;

namespace ExercicioAutoEscola.Pages.Recepcao
{
    public class IndexModel : PageModel
    {
        private readonly ExercicioAutoEscola.Data.ExercicioAutoEscolaContext _context;

        public IndexModel(ExercicioAutoEscola.Data.ExercicioAutoEscolaContext context)
        {
            _context = context;
        }

        public IList<Recepcao> Recepcao { get;set; }

        public async Task OnGetAsync()
        {
            Recepcao = await _context.Recepcao.ToListAsync();
        }
    }
}
