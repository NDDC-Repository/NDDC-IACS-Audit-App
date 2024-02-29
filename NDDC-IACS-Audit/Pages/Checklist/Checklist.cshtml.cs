using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.Checklist
{
    public class ChecklistModel : PageModel
    {
        private readonly NDDCIACSContext context;
        public List<ChecklistTemplate> ChecklistItems { get; set; }

        public ChecklistModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            ChecklistItems = context.ChecklistTemplates
                .OrderByDescending(p => p.Id)
                .ToList();
        }
    }
}
