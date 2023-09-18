using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecturalPattern.WebApi.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
