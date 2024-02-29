using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.AuditControl
{
    public class AuditModel : PageModel
    {
		private readonly NDDCIACSContext context;

		public List<FileControl> Controls { get; set; }

        public AuditModel(NDDCIACSContext context)
        {
			this.context = context;
		}
        public void OnGet()
        {
            Controls = context.FileControls
                .OrderByDescending(e => e.Id)
                .Select(e => new FileControl
                {
                    // Your other properties here
                    Title = e.Title,
                    Originator = e.Originator,
                    OriginatorName = e.OriginatorName,
                    DateAdded = e.DateAdded,
                })
                .ToList()
                .Select((e, index) => new FileControl
                {
                    SrNo = index + 1,
                    Title = e.Title,
                    Originator = e.Originator,
                    OriginatorName = e.OriginatorName,
                    DateAdded = e.DateAdded,
                })
                .ToList();
        }
    }
}
