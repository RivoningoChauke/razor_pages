using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TotorialsEU.Models;

namespace TotorialsEU.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly MyDbContext _context;

        [BindProperty]

        public Person NewPerson { get; set; }

        public PeopleModel(MyDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            _context.People.Add(NewPerson);

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
