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
    public class SubscriptionApplictionController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<SubscriptionAppliction> _subscriptionApplictionRepo;
        public SubscriptionApplictionController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<SubscriptionAppliction> subscriptionApplictionRepo)

        {
            _config = config;
            _context = context;
            _subscriptionApplictionRepo = subscriptionApplictionRepo;

        }

        [HttpPost]
        public ActionResult CreateSubscriptionAppliction(SubscriptionApplictionDTO subscriptionApplictionDTO)
        {

            try
            {
                SubscriptionAppliction subscriptionAppliction = new SubscriptionAppliction();
                subscriptionAppliction.FirstName = subscriptionApplictionDTO.FirstName;
                subscriptionAppliction.LastName = subscriptionApplictionDTO.LastName;
                subscriptionAppliction.Email = subscriptionApplictionDTO.Email;
                subscriptionAppliction.PhoneNumber = subscriptionApplictionDTO.PhoneNumber;
                subscriptionAppliction.Country = subscriptionApplictionDTO.Country;
                subscriptionAppliction.CompanyName = subscriptionApplictionDTO.CompanyName;
                subscriptionAppliction.Companysize = subscriptionApplictionDTO.Companysize;
                subscriptionAppliction.TermsAndconditions = subscriptionApplictionDTO.TermsAndconditions;
                subscriptionAppliction.term = subscriptionApplictionDTO.term;
                subscriptionAppliction.Applictions = subscriptionApplictionDTO.Applictions;
                subscriptionAppliction.CreatedBy = subscriptionApplictionDTO.CreatedBy;
                subscriptionAppliction.CreatedOn = System.DateTime.Now;
                var obj = _subscriptionApplictionRepo.Insert(subscriptionAppliction);

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
                var list = (from u in _context.SubscriptionApplictions


                            select new { u.SubscriptionApplictionId, u.term,u.Applictions, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
