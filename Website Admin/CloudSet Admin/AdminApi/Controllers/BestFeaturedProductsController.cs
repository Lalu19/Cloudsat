using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BestFeaturedProductsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<BestFeaturedProducts> _BestFeaturedProductsRepo;
        public BestFeaturedProductsController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<BestFeaturedProducts> BestFeaturedProductsRepo)

        {
            _config = config;
            _context = context;
            _BestFeaturedProductsRepo = BestFeaturedProductsRepo;

        }
        [HttpPost]
        public IActionResult BestFeaturedProductsCreate(BestFeaturedProductsDTO bestFeaturedProductsDTO)
        {
            try
            {
                BestFeaturedProducts best = new BestFeaturedProducts();
                best.Header = bestFeaturedProductsDTO.Header;
                best.ImageUpload = bestFeaturedProductsDTO.ImageUpload;
                best.CreatedBy = bestFeaturedProductsDTO.CreatedBy;
                best.CreatedOn = System.DateTime.Now;
                var obj = _BestFeaturedProductsRepo.Insert(best);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetBestFeaturedProductsList()
        {
            try
            {
                var list = (from u in _context.BestFeaturedProducts


                            select new { u.BestFeaturedProductsId, u.Header, u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{BestFeaturedProductsId}")]
        public ActionResult GetSingleBestFeaturedProducts(int BestFeaturedProductsId)
        {
            try
            {
                var singleBestFeaturedProducts = _BestFeaturedProductsRepo.SelectById(BestFeaturedProductsId);
                return Ok(singleBestFeaturedProducts);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult UpdateBestFeaturedProducts(UpdateBestFeaturedProductsDTO updateBestFeaturedProductsDTO)
        {
            try
            {
                var objabout = _context.BestFeaturedProducts.SingleOrDefault(opt => opt.BestFeaturedProductsId == updateBestFeaturedProductsDTO.BestFeaturedProductsId);
                objabout.Header = updateBestFeaturedProductsDTO.Header;
                objabout.ImageUpload = updateBestFeaturedProductsDTO.ImageUpload;
                objabout.UpdatedBy = updateBestFeaturedProductsDTO.CreatedBy;
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
        public ActionResult DeleteBestFeaturedProducts(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.BestFeaturedProducts.SingleOrDefault(opt => opt.BestFeaturedProductsId == Id);
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