using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversalLogistics.Data;

namespace UniversalLogistics.Controllers
{
	public class MaterialController : Controller
	{
		private LogisticsContext _context;

		public MaterialController(LogisticsContext context)
		{
			_context = context;
		}


		[Route("/materials")]
		public IActionResult Index()
		{
			// Get all materials from context and display them on the page
			var materials = _context.Materials.ToList();
			return View();
		}
	}
}