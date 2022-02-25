using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace B2B_API.Controllers
{

    [Authorize]
    [Route("mvc/[controller]")]

    public class HomeController : Controller
    {



       
        public IActionResult Index()
        {
            return View();
        }
    }
}
