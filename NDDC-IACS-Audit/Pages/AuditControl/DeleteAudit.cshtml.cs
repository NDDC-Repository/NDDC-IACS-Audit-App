using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.AuditControl
{
    public class DeleteAuditModel : PageModel
    {
        private readonly NDDCIACSContext context;

        public DeleteAuditModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(int? id)
        {
            var entityToDelete = context.FileControls.Find(id.Value);
            if (entityToDelete != null)
            {
                context.FileControls.Remove(entityToDelete);
                context.SaveChanges();
            }

            return RedirectToPage("Audit");
        }
    }
}
