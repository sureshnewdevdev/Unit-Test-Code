using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestingMVC.Models;
using UserService;
namespace UnitTestingMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserMessagingService _userMessagingService;

        public HomeController(IUserMessagingService userMessagingService ,ILogger<HomeController> logger)
        {
            _logger = logger;
            _userMessagingService = userMessagingService;
        }

        public IActionResult Index()
        {
            ViewBag.Message1 = _userMessagingService.GetWelcomeMsgFromDB("") ;
            ViewBag.Message= _userMessagingService.GetMessageFromDB();
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