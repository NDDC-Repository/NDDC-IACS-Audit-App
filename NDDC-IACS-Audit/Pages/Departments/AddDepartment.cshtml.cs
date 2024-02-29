using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.Departments
{
    public class AddDepartmentModel : PageModel
    {
        private readonly NDDCIACSContext context;

        [BindProperty]
        public Directorate Directorate { get; set; }

        public AddDepartmentModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            context.Directorates.Add(Directorate);
            context.SaveChanges();

            return RedirectToPage("AllDepartments");
        }
    }
}
