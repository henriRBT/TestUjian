using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestUjian.Models;
using TestUjian.Repository;


namespace TestUjian.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		public IUnitOfWork _unitOfWork;

		public HomeController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		#region API CALLS 
		[HttpGet]
		public IActionResult GetAll()
		{
			var permohonanData = _unitOfWork.Product.GetPermohonanData();
			return Json(new { data = permohonanData });
		}
		[HttpGet]
		public IActionResult Get()
		{
			var permohonanData = _unitOfWork.Pemohonan.GetData();
			return Json(new { data = permohonanData });
		}

		#endregion
	}
}
