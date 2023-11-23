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
    public class BetterProductController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<BetterProduct> _BetterProductRepo;
        public BetterProductController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<BetterProduct> BetterProductRepo)

        {
            _config = config;
            _context = context;
            _BetterProductRepo = BetterProductRepo;

        }
        [HttpPost]
        public IActionResult BetterProductCreate(BetterProductDTO betterProductDTO)
        {
            try
            {
                BetterProduct betterProduct = new BetterProduct();
                betterProduct.Text = betterProductDTO.Text;
                betterProduct.ImageUpload = betterProductDTO.ImageUpload;
                betterProduct.CreatedBy = betterProductDTO.CreatedBy;
                betterProduct.CreatedOn = System.DateTime.Now;
                var obj = _BetterProductRepo.Insert(betterProduct);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetBetterProductList()
        {
            try
            {
                var list = (from u in _context.BetterProducts


                            select new { u.BetterProductId, u.Text, u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{betterProductid}")]
        public ActionResult GetSingleBetterProduct(int betterProductid)
        {
            try
            {
                var singleBetterProduct = _BetterProductRepo.SelectById(betterProductid);
                return Ok(singleBetterProduct);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult UpdateBetterProduct(UpdateBetterProductDTO updateBetterProductDTO)
        {
            try
            {
                var objabout = _context.BetterProducts.SingleOrDefault(opt => opt.BetterProductId == updateBetterProductDTO.BetterProductId);
                objabout.Text = updateBetterProductDTO.Text;
                objabout.ImageUpload = updateBetterProductDTO.ImageUpload;
                objabout.UpdatedBy = updateBetterProductDTO.CreatedBy;
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
        public ActionResult DeleteBetterProduct(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.BetterProducts.SingleOrDefault(opt => opt.BetterProductId == Id);
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