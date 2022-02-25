using CRM_APP.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRM_APP.Controllers
{
    public class AuthenticateController : Controller
    {
        private readonly ILogger<ManagementPlansController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticateController(ILogger<ManagementPlansController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager,  RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public IActionResult RegisterForm()
        {

            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> RegisterForm([FromBody] RegisterModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }


        public IActionResult LoginForm()
        {

            return View(new LoginModel());
        }
        [HttpPost]
        public  async Task<IActionResult> LoginForm([FromBody]  LoginModel model)
        {


            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                var signInResult = _signInManager.PasswordSignInAsync(user, model.Password,model.RememberMe, true).Result;//sondaki true identity içinde 
                                                                                                                                      //5 kere hatalı girişte 5 dakika boyunca girişi kitleyen bir sistem vardır onu aktif eder

                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Kullanıcı Adı veya şifre hatalı");
            }
            return View(model);
        }

        [AcceptVerbs("Get", "Post")]  // [HttpGet][HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true); //return true no validation error
            }
            else
            {
                return Json($"Email {email} is already in use"); 
            }
        }








        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("UrunlerSayfası", "Urun");
        }
    }
}
