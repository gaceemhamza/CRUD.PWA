using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectPWA.Model;

namespace ProjectPWA.Pages.Employes
{
    public class UpdateEmployeModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public UpdateEmployeModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Employe Employe { get; set; }





        public async Task   OnGet(int id)
        {
            Employe = await _db.Employe.FindAsync(id);
                

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var EmployeFromDb = await _db.Employe.FindAsync(Employe.Id);
                EmployeFromDb.FirstName = Employe.FirstName;
                EmployeFromDb.LastName = Employe.LastName;
                EmployeFromDb.Email = Employe.Email;
                EmployeFromDb.Phone = Employe.Phone;
                EmployeFromDb.Adresse = Employe.Adresse;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}