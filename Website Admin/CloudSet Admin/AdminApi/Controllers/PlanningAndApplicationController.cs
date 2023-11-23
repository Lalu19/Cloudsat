using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlanningAndApplicationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<planningAndApplication> _planningAndApplicationRepo;
        public PlanningAndApplicationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<planningAndApplication> planningAndApplicationRepo)

        {
            _config = config;
            _context = context;
            _planningAndApplicationRepo = planningAndApplicationRepo;

        }
        //create
        [HttpPost]
        public ActionResult planningAndApplicationCreate(PlanningAndapplicationDTO planningAndapplicationDTO)
        {

            try
            {
                planningAndApplication PlanningAndApplication = new planningAndApplication();

                PlanningAndApplication.ApplicationMasterId = planningAndapplicationDTO.ApplicationMasterId;
                PlanningAndApplication.CreatedBy = planningAndapplicationDTO.CreatedBy;
                PlanningAndApplication.PlanningId = planningAndapplicationDTO.PlanningId;
                PlanningAndApplication.CreatedOn = System.DateTime.Now;
                var obj = _planningAndApplicationRepo.Insert(PlanningAndApplication);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetPlanningAndApplicationList()
        {
            try
            {
                var list = (from u in _context.PlanningAndApplications
                            join r in _context.PlanningMasters on
                            u.PlanningId equals r.PlanningId
                            join s in _context.ApplicationMasters on
                            u.ApplicationMasterId equals s.ApplicationMasterId

                            select new { u.planningandapplicationid,r.PlanningId ,r.PlanningName,s.ApplicationMasterId,s.ApplicationMasterName, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{PlanningAndApplicationId}")]
        public ActionResult GetSinglePlanningAndApplication(int PlanningAndApplicationId)
        {
            try
            {
                var singleplanninandapplication = _planningAndApplicationRepo.SelectById(PlanningAndApplicationId);
                return Ok(singleplanninandapplication);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        //update
        [HttpPost]
        public ActionResult updateplanningandapplication(UpdatePlanningandapplicationDTO updatePlanningandapplicationDTO)
        {
            try
            {
                var obj = _context.PlanningAndApplications.SingleOrDefault(opt => opt.planningandapplicationid == updatePlanningandapplicationDTO.planningandapplicationid);
                obj.ApplicationMasterId = updatePlanningandapplicationDTO.ApplicationMasterId;
                obj.PlanningId = updatePlanningandapplicationDTO.PlanningId;
                obj.UpdatedBy = updatePlanningandapplicationDTO.CreatedBy;
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
        public ActionResult Deleteplanningandapplication(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.PlanningAndApplications.SingleOrDefault(opt => opt.planningandapplicationid == Id);
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

        [HttpGet]
        public IActionResult GetPlanWisePricing()
        {
            List<PlanWisePricingViewModel> planWisePricingViewModels = new List<PlanWisePricingViewModel>();
            var plans = _context.PlanningMasters.Where(x => x.IsDeleted == false).ToList();
            var applications = _context.ApplicationMasters.Where(x => x.IsDeleted == false && x.frontpagedisplay.ToLower() == "yes").ToList();
            for(int i=0;i<plans.Count;i++)
            {
                List<ApplicationsPricing> applicationsPricings = new List<ApplicationsPricing>();

                for(int j = 0; j < applications.Count; j++)
                {
                    var planning = _context.PlanningAndApplications.Where(x => x.IsDeleted == false && x.PlanningId == plans[i].PlanningId && x.ApplicationMasterId == applications[j].ApplicationMasterId).FirstOrDefault();
                    if (planning != null)
                    {
                        applicationsPricings.Add(

                            new ApplicationsPricing
                            {
                                ApplicationName = applications[j].ApplicationMasterName,
                                IsAvailable = true
                            });
                    }
                    else
                    {
                        applicationsPricings.Add(

                           new ApplicationsPricing
                           {
                               ApplicationName = applications[j].ApplicationMasterName,
                               IsAvailable = false
                           });
                    }

                }
                planWisePricingViewModels.Add(new PlanWisePricingViewModel
                {

                    PlanId = plans[i].PlanningId,
                    PlanName = plans[i].PlanningName,
                    Monthly = plans[i].PlanningMasterMonthlyPlan,
                    Quaterly = plans[i].PlanningMasterQuaterlyPlan,
                    Halfyearly = plans[i].PlanningMasterHalfYearlyPlan,
                    YearLy = plans[i].PlanningMasterAnnuallyPlan,
                    applicationsPricings = applicationsPricings
                });
            }
            return Ok(planWisePricingViewModels);
        }



        [HttpGet]
        public IActionResult GetPlanWisePricingForPricingPage()
        {
            List<PlanWisePricingViewModel> planWisePricingViewModels = new List<PlanWisePricingViewModel>();
            var plans = _context.PlanningMasters.Where(x => x.IsDeleted == false).ToList();
            var applications = _context.ApplicationMasters.Where(x => x.IsDeleted == false).ToList();
            for (int i = 0; i < plans.Count; i++)
            {
                List<ApplicationsPricing> applicationsPricings = new List<ApplicationsPricing>();

                for (int j = 0; j < applications.Count; j++)
                {
                    var planning = _context.PlanningAndApplications.Where(x => x.IsDeleted == false && x.PlanningId == plans[i].PlanningId && x.ApplicationMasterId == applications[j].ApplicationMasterId).FirstOrDefault();
                    if (planning != null)
                    {
                        applicationsPricings.Add(

                            new ApplicationsPricing
                            {
                                ApplicationName = applications[j].ApplicationMasterName,
                                IsAvailable = true
                            });
                    }
                    else
                    {
                        applicationsPricings.Add(

                           new ApplicationsPricing
                           {
                               ApplicationName = applications[j].ApplicationMasterName,
                               IsAvailable = false
                           });
                    }

                }
                planWisePricingViewModels.Add(new PlanWisePricingViewModel
                {

                    PlanId = plans[i].PlanningId,
                    PlanName = plans[i].PlanningName,
                    Monthly = plans[i].PlanningMasterMonthlyPlan,
                    Quaterly = plans[i].PlanningMasterQuaterlyPlan,
                    Halfyearly = plans[i].PlanningMasterHalfYearlyPlan,
                    YearLy = plans[i].PlanningMasterAnnuallyPlan,
                    applicationsPricings = applicationsPricings
                });
            }
            return Ok(planWisePricingViewModels);
        }
    }

}
