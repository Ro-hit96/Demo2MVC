using Microsoft.AspNetCore.Mvc;

namespace Demo2MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
