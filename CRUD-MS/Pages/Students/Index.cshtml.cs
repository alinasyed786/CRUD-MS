using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_MS.Data;
using CRUD_MS.Model;

namespace CRUD_MS.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_MS.Data.CRUD_MSContext _context;

        public IndexModel(CRUD_MS.Data.CRUD_MSContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
