using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WebsitepagesController : Controller
    {

        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Websitepages> _WebsitepagesRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public WebsitepagesController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Websitepages> WebsitepagesyRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _WebsitepagesRepo = WebsitepagesyRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

       // [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateWebsitepages(WebsitepagesDTO websitepagesDTO)
        {
            var objCheck = _context.Websitepages.SingleOrDefault(opt => opt.Header == websitepagesDTO.Header && opt.IsDeleted == false );
            try
            {
                if (objCheck == null)
                {

                    Websitepages websitepages = new Websitepages();
                    websitepages.CategoryId = websitepagesDTO.CategoryId;                   
                    websitepages.Header = websitepagesDTO.Header;
                    websitepages.Description = websitepagesDTO.Description;
                    websitepages.Description1 = websitepagesDTO.Description1;
                    websitepages.Description2 = websitepagesDTO.Description2;
                    websitepages.Description3 = websitepagesDTO.Description3;
                    websitepages.Description4 = websitepagesDTO.Description4;
                    websitepages.Description5 = websitepagesDTO.Description5;                   
                    websitepages.CreatedBy = websitepagesDTO.CreatedBy;
                    websitepages.CreatedOn = System.DateTime.Now;
                    var obj = _WebsitepagesRepo.Insert(websitepages);
                   
                    return Ok(obj);


                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Pages!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult GetWebsitepagesList()
        {
            try
            {
                var list = (from u in _context.Websitepages
                           

                            select new {u.WebsitePagesId,u.CategoryId,u.Header,u.Description,u.Description1,u.Description2,u.Description3,u.Description4,u.Description5,u.IsDeleted     }).Where(x => x.IsDeleted == false ).ToList();
                

                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




        [HttpGet("{Id}")]
        public ActionResult GetSingleWebsitepages(int Id)
        {
            try
            {
                var singleWebsitepages = _WebsitepagesRepo.SelectById(Id);
                return Ok(singleWebsitepages);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{categoryid}")]
        public ActionResult GetWebsitepagesListbyCategoryId(int categoryid)
        {
            try
            {
                var list = (from u in _context.Websitepages

                            select new { u.WebsitePagesId, u.CategoryId, u.Header, u.Description, u.Description1, u.Description2, u.Description3, u.Description4, u.Description5, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CategoryId==categoryid).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        // [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateWebsitepages(WebsitePageUpdateDTO websitePageUpdateDTO)
        {
            try
            {
                var objWebsitepages = _context.Websitepages.SingleOrDefault(opt => opt.WebsitePagesId == websitePageUpdateDTO.WebsitePagesId);
                objWebsitepages.CategoryId = websitePageUpdateDTO.CategoryId;
                objWebsitepages.Header = websitePageUpdateDTO.Header;
                objWebsitepages.Description = websitePageUpdateDTO.Description;
                objWebsitepages.Description1 = websitePageUpdateDTO.Description1;
                objWebsitepages.Description2 = websitePageUpdateDTO.Description2;
                objWebsitepages.Description3 = websitePageUpdateDTO.Description3;
                objWebsitepages.Description4 = websitePageUpdateDTO.Description4;
                objWebsitepages.Description5 = websitePageUpdateDTO.Description5;
                
                objWebsitepages.UpdatedBy = websitePageUpdateDTO.CreatedBy;
                objWebsitepages.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(objWebsitepages);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


       // [Authorize(Roles = "Admin")]
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteWebsitepages(int Id, int DeletedBy)
        {
            try
            {
                var objWebsitepages = _context.Websitepages.SingleOrDefault(opt => opt.WebsitePagesId == Id);
                objWebsitepages.IsDeleted = true;

                objWebsitepages.UpdatedBy = DeletedBy;
                objWebsitepages.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objWebsitepages);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
