using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class MargERPController : Controller
    {
        public IActionResult MargERPCreate()
        {
            return View();
        }
        public IActionResult MargERPList()
        {
            return View();
        }
        public IActionResult MargERPEdit(int margERPId)
        {
            ViewBag.margERPId = margERPId;
            return View();
        }
    }
}
