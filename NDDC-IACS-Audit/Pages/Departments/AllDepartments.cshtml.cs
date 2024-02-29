using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;

namespace NDDC_IACS_Audit.Pages.Departments
{
    public class AllDepartmentsModel : PageModel
    {
        private readonly NDDCIACSContext context;
        public List<Directorate> Departments { get; set; }

        public AllDepartmentsModel(NDDCIACSContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Departments = context.Directorates
                .OrderByDescending(p => p.Id)
                .ToList();

        }
    }
}
