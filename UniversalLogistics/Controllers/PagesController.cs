using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UniversalLogistics.Models;

namespace UniversalLogistics.Controllers
{
	public class PagesController : Controller
	{
		private readonly ILogger<PagesController> _logger;

		public PagesController(ILogger<PagesController> logger)
		{
			_logger = logger;
		}


		[Route("/buildings")]
		public IActionResult BuildingUse()
		{
			return View();
		}

		[Route("/supplychains")]
		public IActionResult SupplyChain()
		{
			return View();
		}

		[Route("/consumption")]
		public IActionResult Consumption()
		{
			return View();
		}

		[Route("/about")]
		public IActionResult About()
		{
			return View();
		}

		[Route("/settings")]
		public IActionResult Settings()
		{
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}