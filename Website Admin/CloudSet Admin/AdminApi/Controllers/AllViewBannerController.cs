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
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AllViewBannerController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<AllViewBanner> _AllViewBannerRepo;
        public AllViewBannerController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<AllViewBanner> AllViewBannerRepo)

        {
            _config = config;
            _context = context;
            _AllViewBannerRepo = AllViewBannerRepo;

        }
        //create
        [HttpPost]
        public ActionResult uploadAllViewBanner(AllViewBannerDTO allViewBannerDTO)
        {

            try
            {
                AllViewBanner allViewBanner = new AllViewBanner();
                allViewBanner.Text = allViewBannerDTO.Text;               
                allViewBanner.CategoryId = allViewBannerDTO.CategoryId;
                allViewBanner.CreatedBy = allViewBannerDTO.CreatedBy;
                allViewBanner.CreatedOn = System.DateTime.Now;
                var obj = _AllViewBannerRepo.Insert(allViewBanner);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //list
        [HttpGet]
        public ActionResult GetAllViewBannerList()
        {
            try
            {
                var list = (from u in _context.AllViewBanners
                            join s in _context.Categories on
                            u.CategoryId equals s.CategoryId
                            select new
                            {
                                u.ImageId,
                                u.Text,                               
                                u.CategoryId,                               
                                s.CategoryName,

                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsimg = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{ImageId}")]
        public ActionResult GetSingleAllViewBanner(int ImageId)
        {
            try
            {
                var singleImage = _AllViewBannerRepo.SelectById(ImageId);
                return Ok(singleImage);
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
                var list = (from u in _context.AllViewBanners


                            select new
                            {
                                
                                u.CategoryId,
                                u.ImageId,
                                u.Text,                               
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CategoryId == categoryid).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateAllViewBanner(UpdateAllViewBannerDTO updateAllViewBannerDTO)
        {
            try
            {
                var objimg = _context.AllViewBanners.SingleOrDefault(opt => opt.ImageId == updateAllViewBannerDTO.ImageId);
                objimg.Text = updateAllViewBannerDTO.Text;                
                objimg.CategoryId = updateAllViewBannerDTO.CategoryId;                
                objimg.UpdatedBy = updateAllViewBannerDTO.CreatedBy;
                objimg.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(objimg);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteAllViewBanner(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.AllViewBanners.SingleOrDefault(opt => opt.ImageId == Id);
                objimg.IsDeleted = true;

                objimg.UpdatedBy = DeletedBy;
                objimg.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objimg);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}