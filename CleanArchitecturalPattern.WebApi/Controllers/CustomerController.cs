using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
