using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    public class CustomerController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
