using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NDDC_IACS_Audit.Models;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace NDDC_IACS_Audit.Pages.AuditControl
{
    public class AddAuditModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public FileControl Control { get; set; }
        public List<Directorate> Departments { get; set; }
        public Directorate Department { get; set; }

        private readonly NDDCIACSContext context;

		public AddAuditModel(NDDCIACSContext context)
        {
			this.context = context;
		}
        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                Departments = context.Directorates.ToList();
                Control = context.FileControls
                    .Where(p => p.Id == id.Value)
                    .ToList().First();
                Departments = context.Directorates.ToList();
            }
            else
            {
                //FileControl cont = new();
                //cont.DirectorateId = 0;
                Departments = context.Directorates.ToList();
            }
            
        }
        public IActionResult OnPost(int? id)
        {
            if (id.HasValue)
            {
                Control.DateAdded = DateTime.Now;
                Control.AddedBy = "Admin";
                context.FileControls.Update(Control);
                context.SaveChanges();

                return RedirectToPage("Audit");
            }
            else
            {
                Control.DateAdded = DateTime.Now;
                Control.AddedBy = "Admin";

                context.FileControls.Add(Control);
                context.SaveChanges();

                return RedirectToPage("Audit");
            }
           
        }
    }
}
