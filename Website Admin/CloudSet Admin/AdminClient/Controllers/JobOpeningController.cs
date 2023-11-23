using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class JobOpeningController : Controller
    {
        public IActionResult JobOpeningCreate()
        {
            return View();
        }
        public IActionResult JobOpeningList()
        {
            return View();
        }
        public IActionResult JobOpeningEdit(int jobOpeningId)
        {
            ViewBag.jobOpeningId = jobOpeningId;
            return View();
        }
    }
}
