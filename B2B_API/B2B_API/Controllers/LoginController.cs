using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using B2B_API.Model;
using B2B_API.Auth;
using Microsoft.AspNetCore.Identity;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace B2B_API.Controllers
{
    [AllowAnonymous]
    [Route("mvc/[controller]")]

    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _signInManager = signInManager;
        }





        public IActionResult LoginForm()
        {


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> LoginForm(LoginModel model)
        {


            if (ModelState.IsValid)
            {
                bool persistent = true;
                AuthenticateController authenticateController = new AuthenticateController(_userManager, _roleManager, _configuration);
            var result=   await  authenticateController.Login(model);

                var jsondata = JsonConvert.SerializeObject(result);
                //var jsondatav2 = JArray.Parse(jsondata.ToString());
                //var token = jsondatav2.Children();

                //var realtoken = token[1];

               var token = jsondata.Substring(18, jsondata.Length - 110);


                return RedirectToAction("Index","Home");
                
            }
            return View(model);
        }




    }
}
