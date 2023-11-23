using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using System;
    
namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TermsandconditionsController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<termsandconditions> _termsandconditionsRepo;
        public TermsandconditionsController(IConfiguration config,
                               AppDbContext context,
                               ISqlRepository<termsandconditions> termsandconditionsRepo)
        {
            _config = config;
            _context = context;
            _termsandconditionsRepo = termsandconditionsRepo;
        }
        [HttpPost]
        public ActionResult TermsandconditionsCreate(termsandconditionsDTO termsandconditionsDTO )
        {

            try
            {
                termsandconditions terms = new termsandconditions();

                terms.termsandconditionText = termsandconditionsDTO.termsandconditionText;
                terms.CreatedBy = termsandconditionsDTO.CreatedBy;
                terms.CreatedOn = System.DateTime.Now;
                var obj = _termsandconditionsRepo.Insert(terms);
                return Ok(obj);

             
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetTermsandconditions()
        {
            try
            {
                var list = (from u in _context.Termsandconditions


                            select new { u.termsandconditionsid, u.termsandconditionText, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{termsandconditionsid}")]
        public ActionResult GetTermsandconditions(int termsandconditionsid)
        {
            try
            {
                var single = _termsandconditionsRepo.SelectById(termsandconditionsid);
                return Ok(single);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        //update
        [HttpPost]
        public ActionResult UpdateTermsandconditions(UpdatetermsandconditionsDTO updatetermsandconditionsDTO)
        {
            try
            {
                var obj = _context.Termsandconditions.SingleOrDefault(opt => opt.termsandconditionsid == updatetermsandconditionsDTO.termsandconditionsid);
                obj.termsandconditionText = updatetermsandconditionsDTO.termsandconditionText;
                obj.UpdatedBy = updatetermsandconditionsDTO.CreatedBy;
                obj.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteTermsandconditions(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.Termsandconditions.SingleOrDefault(opt => opt.termsandconditionsid == Id);
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
