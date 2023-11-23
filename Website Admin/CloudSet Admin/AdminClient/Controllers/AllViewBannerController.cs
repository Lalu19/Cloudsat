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
    public class AllViewBannerController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string _apiBaseUrl;

        public AllViewBannerController(IConfiguration configuration)
        {

            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }
        public IActionResult AllViewBannerCreate()
        {
            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase","SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };

            return View();
        }

        public IActionResult AllViewBannerList()
        {
            return View();
        }

        public IActionResult AllViewBannerEdit(int imageId)
        {
            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase","SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };
            ViewBag.imageId = imageId;
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
                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = "#", text = categoryList[i].CategoryName });
                            }
                            else
                            {
                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].CategoryName });
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

                                nodes.Add(new JsTreeModel() { id = categoryList[i].CategoryId.ToString(), parent = categoryList[i].Parent.ToString(), text = categoryList[i].CategoryName });
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
