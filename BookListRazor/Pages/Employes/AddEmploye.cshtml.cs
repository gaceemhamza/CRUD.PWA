using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectPWA.Model;

namespace ProjectPWA.Pages.Employes
{
    public class AddEmployeModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public AddEmployeModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]

        public new Employe Employe { get; set; }



        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Employe.AddAsync(Employe);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }

}
