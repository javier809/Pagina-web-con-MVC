using Microsoft.AspNetCore.Mvc;

namespace WebManualMVC.Controllers
{
    public class PaquetesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
