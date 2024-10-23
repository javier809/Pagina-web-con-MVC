using Microsoft.AspNetCore.Mvc;

namespace WebManualMVC.Controllers
{
    public class GitHutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
