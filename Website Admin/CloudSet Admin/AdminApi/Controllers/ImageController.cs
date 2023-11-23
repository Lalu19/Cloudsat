
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
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ImageController : Controller
    {

        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Image> _ImageRepo;
        public ImageController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Image> ImageRepo)
                               
        {
            _config = config;
            _context = context;
            _ImageRepo = ImageRepo;
           
        }
        //create
        [HttpPost]
        public ActionResult uploadimage(ImageDTO imageDTO)
        {

            try
            {
                Image image = new Image();
                image.ImageUpload = imageDTO.ImageUpload;
                image.CategoryId = imageDTO.CategoryId; 
                image.WebsitePages = imageDTO.WebsitePages;
                image.Largecontent = imageDTO.Largecontent;
                image.CreatedBy = imageDTO.CreatedBy;
                image.CreatedOn = System.DateTime.Now;
                var obj = _ImageRepo.Insert(image);
                return Ok(obj);
              
               
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //list
        [HttpGet]
        public ActionResult GetimageList()
        {
            try
            {
                var list = (from u in _context.Images                            
                            join s in _context.Categories on
                            u.CategoryId equals s.CategoryId
                            select new { u.ImageId,
                                u.ImageUpload,
                                u.CategoryId,
                                u.WebsitePages,
                               u.Largecontent,
                                s.CategoryName,
                               
                                u.IsDeleted }).Where(x => x.IsDeleted == false);
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
        public ActionResult GetSingleImage(int ImageId)
        {
            try
            {
                var singleImage = _ImageRepo.SelectById(ImageId);
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
                var list = (from u in _context.Images
                           

                            select new { u.WebsitePages, u.CategoryId,u.ImageId,u.ImageUpload,u.Largecontent,


                                u.IsDeleted }).Where(x => x.IsDeleted == false && x.CategoryId == categoryid).ToList();


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
        public ActionResult updateimagaes(ImageUpdateDTO imageUpdateDTO)
        {
            try
            {
                var objimg = _context.Images.SingleOrDefault(opt => opt.ImageId == imageUpdateDTO.ImageId);
                objimg.ImageUpload = imageUpdateDTO.ImageUpload;
                objimg.CategoryId = imageUpdateDTO.CategoryId;
                objimg.WebsitePages = imageUpdateDTO.WebsitePages; 
                objimg.Largecontent = imageUpdateDTO.Largecontent;

                objimg.UpdatedBy = imageUpdateDTO.CreatedBy;
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
        public ActionResult Deleteimg(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.Images.SingleOrDefault(opt => opt.ImageId == Id);
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