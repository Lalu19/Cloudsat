using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
	public class PlanningMasterController : Controller
	{
		public IActionResult PlanningMasterCreate()
		{
			return View();
		}
        public IActionResult PlanningMasterEdit(int planningId)
        {
            ViewBag.planningId = planningId;
            return View();
        }
        public IActionResult PlanningMasterList()
        {
            return View();
        }
    }
}
