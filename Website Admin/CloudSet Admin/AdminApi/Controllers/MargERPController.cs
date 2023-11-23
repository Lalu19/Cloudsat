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
    public class MargERPController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<MargERP> _MargERPRepo;
        public MargERPController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<MargERP> MargERPRepo)

        {
            _config = config;
            _context = context;
            _MargERPRepo = MargERPRepo;

        }
        [HttpPost]
        public IActionResult MargERPCreate(MargERPDTO margERPDTO)
        {
            try
            {
                MargERP margERP = new MargERP();

                margERP.ImageUpload = margERPDTO.ImageUpload;
                margERP.CreatedBy = margERPDTO.CreatedBy;
                margERP.CreatedOn = System.DateTime.Now;
                var obj = _MargERPRepo.Insert(margERP);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetMargERPList()
        {
            try
            {
                var list = (from u in _context.MargERPs


                            select new { u.MargERPId, u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{MargERPid}")]
        public ActionResult GetSingleMargERP(int MargERPid)
        {
            try
            {
                var singleMargERP = _MargERPRepo.SelectById(MargERPid);
                return Ok(singleMargERP);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateMargERP(UpdateMargERPDTO updateMargERPDTO)
        {
            try
            {
                var objabout = _context.MargERPs.SingleOrDefault(opt => opt.MargERPId == updateMargERPDTO.MargERPId);
               
                objabout.ImageUpload = updateMargERPDTO.ImageUpload;
                objabout.UpdatedBy = updateMargERPDTO.CreatedBy;
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
        public ActionResult DeleteMargERP(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.MargERPs.SingleOrDefault(opt => opt.MargERPId == Id);
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
