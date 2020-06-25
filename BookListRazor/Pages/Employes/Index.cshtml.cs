using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProjectPWA.Pages.Employes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;


        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ProjectPWA.Model.Employe> Employes { get; set; }

        public async Task OnGet()
        {
            Employes = await _db.Employe.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Employe = await _db.Employe.FindAsync(id);
            if(Employe == null)
            {
                return NotFound();
            }
            _db.Employe.Remove(Employe);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

        }




    }
}