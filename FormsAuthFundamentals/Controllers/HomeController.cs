using FormsAuthFundamentals.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormsAuthFundamentals.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // ExecuteCustomerQry("truc customer");
        //public object ExecuteCustomerQry(string name)
        //{
        //    var result = ExecSqlQry(name);
        //    return 1;
        //}

        // 10 union select * from customers
        //private object ExecSqlQry(string studentid)
        //{

        //    var execQry = "SELECT * FROM students WHERE studentId = 10 union select * from customers";
        //    throw new NotImplementedException();
        //}
        // Injection
        // Broken Authentication
        // Sensitive Data Exposure 
        // XML External Entities (XEE) xdata json - vercode scanning ,sonarqube
        // Broken Access Control
        // Cross-Site Scripting
        //private object ExecSqlQryEntity(Student student)
        //{
        //    // list type list<student> 
        //    var execQry = students.where (s=>s.id = student.id);
        //    throw new NotImplementedException();
        //}

        public string OpenDBConnection()
        {
            string conString = CommonLib.CommonVarianles.ConnectionString;
            // connect to db

            return "Connected";
        }
    }
}