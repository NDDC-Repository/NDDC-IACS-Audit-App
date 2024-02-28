using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NDDC_IACS_Audit.Models;
using System.Diagnostics;

namespace NDDC_IACS_Audit.Pages
{
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	[IgnoreAntiforgeryToken]
	public class ErrorModel : PageModel
	{
		public string? RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

		private readonly ILogger<ErrorModel> _logger;
		private readonly NDDCIACSContext context;

        public List<Directorate> Directorates { get; set; }

        public ErrorModel(ILogger<ErrorModel> logger, NDDCIACSContext context)
		{
			_logger = logger;
			this.context = context;
		}

		public void OnGet()
		{
			RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
			Directorates = context.Directorates.ToList();
		}
	}

}
