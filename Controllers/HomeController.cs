using CoursesRegister.Models;
using Login_Register_App.Data;
using Login_Register_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login_Register_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext context;


        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Add(user);
            context.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var existing_user = context.Users.Where(p => p.userName == user.userName).First();
            if (user.password == existing_user.password.ToString())
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return RedirectToAction("WrongCredentials");
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            return View(context.Courses);
        }

        public IActionResult WrongCredentials()
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