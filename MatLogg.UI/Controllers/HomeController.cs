using MatLogg.Application.DTOs;
using MatLogg.Application.Interfaces;
using MatLogg.Infrastructure.Data;
using MatLogg.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MatLogg.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ISaveFoodService _saveFoodService;

		public HomeController(ILogger<HomeController> logger, ISaveFoodService saveFoodService)
		{
			_logger = logger;
			_saveFoodService = saveFoodService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Food()
		{
			return View();
		}

		public IActionResult SubmitAddFoodForm(SaveFoodDTO saveFoodDTO) 
		{
			_dbContext.SaveFoods.Add(saveFoodDTO);
			return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
