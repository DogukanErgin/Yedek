
using asp.net_core_deneme2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace asp.net_core_deneme2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Myview()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Hour = hour > 12 ? "good afternoon" : "Good morning";
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student Student)
        {
            //model binding
            //student bilgisini veritabanı kaydedebilirsin
            if (ModelState.IsValid)   //formu doldurup submit bastığımızda modelstate tarafında hata yoksa isvalid true dur
            {
                Repository.AddStudent(Student);
                return View("Done", Student);
            }
            else
            {
                return View();
            }
        }
        public ViewResult List()
        {
           var liste= Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
