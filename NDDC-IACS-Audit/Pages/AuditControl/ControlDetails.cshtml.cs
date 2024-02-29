using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.AuditControl
{
    public class ControlDetailsModel : PageModel
    {
        private readonly NDDCIACSContext context;
        public FileControl Control { get; set; }

        public ControlDetailsModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet(int? id)
        {
            Control = context.FileControls.ToList()
                .Where(p => p.Id == id.Value)
                .First();
        }
    }
}
