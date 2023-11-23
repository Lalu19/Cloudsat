using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class Home : Controller
    {
        public IActionResult CuisineCreate()
        {
            return View();
        }
        public IActionResult CuisineView()
        {
            return View();
        }
        public IActionResult CuisineEdit()
        {
            return View();
        }
    }
}
