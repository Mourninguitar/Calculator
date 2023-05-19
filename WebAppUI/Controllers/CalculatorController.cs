using Microsoft.AspNetCore.Mvc;

namespace WebAppUI.Controllers
{
	public class CalculatorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
