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
    public class PrivacyPolicyController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PrivacyPolicy> _PrivacyPolicyRepo;
        public PrivacyPolicyController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PrivacyPolicy> PrivacyPolicyRepo)

        {
            _config = config;
            _context = context;
            _PrivacyPolicyRepo = PrivacyPolicyRepo;

        }
        [HttpPost]
        public ActionResult PrivacyPolicyCreate(PrivacyPolicyDTO privacyPolicyDTO)
        {

            try
            {
                PrivacyPolicy privacy = new PrivacyPolicy();

                privacy.Text = privacyPolicyDTO.Text;
                privacy.CreatedBy = privacyPolicyDTO.CreatedBy;
                privacy.CreatedOn = System.DateTime.Now;
                var obj = _PrivacyPolicyRepo.Insert(privacy);
                
                
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetPrivacypolicy()
        {
            try
            {
                var list = (from u in _context.PrivacyPolicies


                            select new { u.PrivacyPolicyid, u.Text, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{privacyid}")]
        public ActionResult GetSinglePrivacypolicy(int privacyid)
        {
            try
            {
                var single = _PrivacyPolicyRepo.SelectById(privacyid);
                return Ok(single);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        //update
        [HttpPost]
        public ActionResult UpdatePrivacypolicy(UpdatePrivacyPolicyDTO updatePrivacyPolicyDTO)
        {
            try
            {
                var obj = _context.PrivacyPolicies.SingleOrDefault(opt => opt.PrivacyPolicyid == updatePrivacyPolicyDTO.PrivacyPolicyid);
                obj.Text = updatePrivacyPolicyDTO.Text;
                obj.UpdatedBy = updatePrivacyPolicyDTO.CreatedBy;
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
        public ActionResult DeleteprivacyPolicy(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.PrivacyPolicies.SingleOrDefault(opt => opt.PrivacyPolicyid == Id);
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