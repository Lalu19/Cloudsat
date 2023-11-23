using AdminClient.ViewModels.App;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdminClient.Controllers
{
    public class ApplicationMasterController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _apiBaseUrl;

        public ApplicationMasterController(IConfiguration configuration)
        {

            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }
        public IActionResult ApplicationMasterCreate()
        {
            return View();
        }
        public IActionResult ApplicationMasterList()
        {
            return View();
        }
        public IActionResult ApplicationMasterEdit(int applicationMasterId)
        {
            ViewBag.applicationMasterId = applicationMasterId;
            return View();
        }

        public async Task<IActionResult> Nodes()
        {
            var nodes = new List<JsTreeModel>();



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
                                nodes.Add(new JsTreeModel() { id = categoryList[i].ApplicationMasterId.ToString(), parent = "#", text = categoryList[i].ApplicationMasterName });
                            }
                            else
                            {
                                nodes.Add(new JsTreeModel() { id = categoryList[i].ApplicationMasterId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].ApplicationMasterName });
                            }
                        }


                    }
                }
            }



            return Json(nodes);
        }



        public async Task<IActionResult> WithPrimaryNodes()
        {
            var nodes = new List<JsTreeModel>();

            nodes.Add(new JsTreeModel() { id = "0", parent = "#", text = "Primary" });

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
                                nodes.Add(new JsTreeModel() { id = categoryList[i].ApplicationMasterId.ToString(), parent = "#", text = categoryList[i].ApplicationMasterName });
                            }
                            else
                            {

                                nodes.Add(new JsTreeModel() {id = categoryList[i].ApplicationMasterId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].ApplicationMasterName });
                            }
                        }


                    }
                }
            }



            return Json(nodes);
        }
        public async Task<ActionResult> GetApplicationList()
        {

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




                        return Ok(new { data = categoryList });

                    }
                }
            }
            return BadRequest();

        }
    }

}

