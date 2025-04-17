using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ProfileController: Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
