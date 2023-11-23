using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<AboutUs> _AboutUsRepo;
        public AboutUsController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<AboutUs> AboutUsRepo)

        {
            _config = config;
            _context = context;
            _AboutUsRepo = AboutUsRepo;

        }
        [HttpPost]
        public IActionResult AboutUsCreate(AboutUsDTO aboutUsDTO)
        {
            try
            {
                AboutUs about = new AboutUs();
                about.Text = aboutUsDTO.Text;
                about.ImageUpload = aboutUsDTO.ImageUpload;
                about.CreatedBy = aboutUsDTO.CreatedBy;
                about.CreatedOn = System.DateTime.Now;
                var obj = _AboutUsRepo.Insert(about);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetAbboutUsList()
        {
            try
            {
                var list = (from u in _context.AboutUs


                            select new { u.AboutUsId, u.Text, u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{aboutid}")]
        public ActionResult GetSingleAboutUs(int aboutid)
        {
            try
            {
                var singleAboutUs = _AboutUsRepo.SelectById(aboutid);
                return Ok(singleAboutUs);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateAboutus(AboutUsUpdateDTO aboutUsUpdateDTO)
        {
            try
            {
                var objabout = _context.AboutUs.SingleOrDefault(opt => opt.AboutUsId == aboutUsUpdateDTO.AboutUsId);
                objabout.Text = aboutUsUpdateDTO.Text;
                objabout.ImageUpload = aboutUsUpdateDTO.ImageUpload;
                objabout.UpdatedBy = aboutUsUpdateDTO.UpdatedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteAbout(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.AboutUs.SingleOrDefault(opt => opt.AboutUsId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}