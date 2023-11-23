using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class DownloadApplicationController : Controller
    {
        public IActionResult DownloadApplicationCreate()
        {
            return View();
        }

        public IActionResult DownloadApplicationList()
        {
            return View();
        }

        public IActionResult DownloadApplicationEdit(int DownloadApplicationId)
        {
            ViewBag.DownloadApplicationId = DownloadApplicationId;
            return View();
        }
    }
}
