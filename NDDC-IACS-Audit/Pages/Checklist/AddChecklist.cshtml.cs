using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.Checklist
{
    public class AddChecklistModel : PageModel
    {
        private readonly NDDCIACSContext context;
        [BindProperty]
        public ChecklistTemplate Checklist { get; set; }

        public AddChecklistModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            context.ChecklistTemplates.Add(Checklist);
            context.SaveChanges();

            return RedirectToPage("Checklist");
        }
    }
}
