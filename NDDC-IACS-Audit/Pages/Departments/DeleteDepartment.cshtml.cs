using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.Departments
{
    public class DeleteDepartmentModel : PageModel
    {
        private readonly NDDCIACSContext context;

        public DeleteDepartmentModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(int? id)
        {
            var entityToDelete = context.Directorates.Find(id.Value);
            if (entityToDelete != null)
            {
                context.Directorates.Remove(entityToDelete);
                context.SaveChanges();
            }

            return RedirectToPage("AllDepartments");
        }
    }
}
