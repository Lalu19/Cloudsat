using AdminClient.ViewModels.App;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _apiBaseUrl;

        public CategoryController(IConfiguration configuration)
        {

            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }
        [HttpGet]
        public IActionResult CategoryList()
        {

            return View();
        }
        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CategoryEdit(int categoryid)
        {
            ViewBag.categoryid = categoryid;
            return View();
        }
        public async Task<IActionResult> Nodes()
        {
            var nodes = new List<JsTreeModel>();



            string apiUrl = _apiBaseUrl + "/api/Category/GetCategoryList";
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var categoryList = JsonConvert.DeserializeObject<List<CategoryDisplay>>(apiResponse);



                        for (int i = 0; i < categoryList.Count; i++)
                        {

                            if (categoryList[i].Parent == null)
                            {
                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = "#", text = categoryList[i].CategoryName  });
                            }
                            else
                            {
                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].CategoryName  });
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

            string apiUrl = _apiBaseUrl + "/api/Category/GetCategoryList";
            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var categoryList = JsonConvert.DeserializeObject<List<CategoryDisplay>>(apiResponse);



                        for (int i = 0; i < categoryList.Count; i++)
                        {

                            if (categoryList[i].Parent == null)
                            {
                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = "#", text = categoryList[i].CategoryName });
                            }
                            else
                            {

                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].CategoryName  });
                            }
                        }


                    }
                }
            }



            return Json(nodes);
        }
        public async Task<ActionResult> GetCategoryList()
        {

            string apiUrl = _apiBaseUrl + "/api/Category/GetCategoryList";

            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        var categoryList = JsonConvert.DeserializeObject<List<CategoryDisplay>>(apiResponse);
                       


                       
                        return Ok(new { data = categoryList });

                    }
                }
            }
            return BadRequest();

        }
    }
}
