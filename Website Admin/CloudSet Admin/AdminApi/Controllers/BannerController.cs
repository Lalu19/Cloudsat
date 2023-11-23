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
    public class BannerController : ControllerBase
    {
        private readonly IConfiguration _config;
       private readonly AppDbContext _context;
        private readonly ISqlRepository<Banner> _BannerRepo;
        public BannerController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Banner> BannerRepo)

        {
            _config = config;
            _context = context;
            _BannerRepo = BannerRepo;

        }
        //create
        [HttpPost]
        public ActionResult uploadBanner(BannerDTO bannerDTO)
        {

            try
            {
                Banner banner = new Banner();

                banner.ImageUpload = bannerDTO.ImageUpload;                
                banner.CreatedBy = bannerDTO.CreatedBy;
                banner.CreatedOn = System.DateTime.Now;
                var obj = _BannerRepo.Insert(banner);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetbannerList()
        {
            try
            {
                var list = (from u in _context.Banners


                            select new { u.bannerId,u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{bannerId}")]
        public ActionResult GetSinglebanner(int bannerId)
        {
            try
            {
                var singleImage = _BannerRepo.SelectById(bannerId);
                return Ok(singleImage);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

       
        //update
        [HttpPost]
        public ActionResult updatebanners(UpdatebanerDTO updatebanerDTO)
        {
            try
            {
                var objimg = _context.Banners.SingleOrDefault(opt => opt.bannerId == updatebanerDTO.bannerId);
                objimg.ImageUpload = updatebanerDTO.ImageUpload;               
                objimg.UpdatedBy = updatebanerDTO.CreatedBy;
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
        public ActionResult Deletebanner(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.Banners.SingleOrDefault(opt => opt.bannerId == Id);
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

