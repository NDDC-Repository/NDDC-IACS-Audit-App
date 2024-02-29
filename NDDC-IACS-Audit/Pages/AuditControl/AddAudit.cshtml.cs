using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;
using System.ComponentModel;

namespace NDDC_IACS_Audit.Pages.AuditControl
{
    public class AddAuditModel : PageModel
    {
        [BindProperty]
        public FileControl Control { get; set; }

        private readonly NDDCIACSContext context;

		public AddAuditModel(NDDCIACSContext context)
        {
			this.context = context;
		}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Control.DateAdded = DateTime.Now;
            Control.AddedBy = "Admin";

            context.FileControls.Add(Control);
            context.SaveChanges();

            return RedirectToPage("Audit");
        }
    }
}
