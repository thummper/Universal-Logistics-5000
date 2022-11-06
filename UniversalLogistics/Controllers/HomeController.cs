using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace UniversalLogistics.Controllers
{
	public class HomeController : Controller
	{
		[Route("")]
		public IActionResult Index(string id)
		{
			return View(id);
		}
	}
}