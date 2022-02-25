using CRM_APP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRM_APP.Controllers
{
    public class ManagementPlansController : Controller
    {
        private readonly ILogger<ManagementPlansController> _logger;

        public ManagementPlansController(ILogger<ManagementPlansController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
    }
}