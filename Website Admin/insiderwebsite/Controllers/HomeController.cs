using insiderwebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace insiderwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _apiBaseUrl;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult Downloads()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Careers(int jobOpeningId)
        {
            ViewBag.jobOpeningId = jobOpeningId;
            return View();
        }  
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult JOBOpening()
        {
            return View();
        }
        public IActionResult Coustmize()
        {
            return View();
        }

        public IActionResult ThankYouPage()
        {
            return View();
        }

        public IActionResult Registration(string apps,string terms)
        {
            ViewBag.apps = apps;
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult Termsandconditions()
        {
            return View();
        }

        public IActionResult ViewPage(int categoryId)
        {
            ViewBag.categoryId = categoryId;
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public async Task<IActionResult> Nodes()
        {
            List<AppCategory> appCategories = new List<AppCategory>();


            string apiUrl = _apiBaseUrl + "/api/ApplicationMaster/GetApplicationMasterList";
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);

                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var categoryList = JsonConvert.DeserializeObject<List<ApplicationDisplay>>(apiResponse);



                        for (int i = 0; i < categoryList.Count; i++)
                        {

                            if (categoryList[i].Parent == null)
                            {
                                appCategories.Add(new AppCategory
                                {
                                    AppId = categoryList[i].ApplicationMasterId.ToString(),
                                    AppName = categoryList[i].ApplicationMasterName,
                                    child = new List<AppCategory>()
                                });
                            }

                        }
                        for (int j = 00; j < appCategories.Count; j++)
                        {
                            var nct = categoryList.Where(x => x.Parent.ToString() == appCategories[j].AppId).ToList();
                            for (int i = 0; i < nct.Count; i++)
                            {


                                appCategories[j].child.Add(new AppCategory
                                {
                                    AppId = nct[i].ApplicationMasterId.ToString(),
                                    AppName = nct[i].ApplicationMasterName,
                                    child = new List<AppCategory>()
                                });


                            }

                        }


                    }
                }
            }



            return Json(appCategories);
        }


    }
    public class AppCategory
    {
        public string AppName { get; set; }
        public string AppId { get; set; }
        public List<AppCategory> child { get; set; }
    }
    public class ApplicationDisplay
    {
        public int ApplicationMasterId { get; set; }
        public string ApplicationMasterName { get; set; }
        public string ApplicationMasterLogo { get; set; }
        public int? Parent { get; set; }
        public string ApplicationMasterMonthlyPrice { get; set; }
        public string ApplicationMasterQuarterlyPrice { get; set; }
        public string ApplicationMasterHalfyearlyPrice { get; set; }
        public string ApplicationMasterYearlyPrice { get; set; }
        public string packagename { get; set; }
        public string frontpagedisplay { get; set; }

        public string ParentName { get; set; }
    }
}
