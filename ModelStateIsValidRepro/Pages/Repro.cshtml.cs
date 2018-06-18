using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ModelStateIsValidRepro.Pages
{
    [BindProperties]
    public class ReproModel : PageModel
    {
        [Required]
        public string TestProperty {get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            return Page();
        }
    }
}