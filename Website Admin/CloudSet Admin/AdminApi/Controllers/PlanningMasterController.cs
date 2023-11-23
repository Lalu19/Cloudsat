using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Linq;

namespace AdminApi.Controllers
{

	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PlanningMasterController : Controller
	{

		private readonly IConfiguration _config;
		private readonly AppDbContext _context;
		private readonly ISqlRepository<PlanningMaster> _PlanningMasterRepo;
		public PlanningMasterController(IConfiguration config,
								AppDbContext context,
								ISqlRepository<PlanningMaster> PlanningMasterRepo)

		{
			_config = config;
			_context = context;
			_PlanningMasterRepo = PlanningMasterRepo;

		}

		
		[HttpPost]
		public ActionResult CreatePlanningMaster(PlanningMasterDTO planningMasterDTO)
		{
			//var objCheck = _context.PlanningMasters.SingleOrDefault(opt => opt.IsDeleted == false );
			try
			{
				//if (objCheck == null)
				//{

					PlanningMaster planningMaster = new PlanningMaster();
					planningMaster.PlanningName = planningMasterDTO.PlanningName;
					planningMaster.PlanningMasterMonthlyPlan = planningMasterDTO.PlanningMasterMonthlyPlan;
					planningMaster.PlanningMasterQuaterlyPlan = planningMasterDTO.PlanningMasterQuaterlyPlan;
					planningMaster.PlanningMasterHalfYearlyPlan = planningMasterDTO.PlanningMasterHalfYearlyPlan;
					planningMaster.PlanningMasterAnnuallyPlan = planningMasterDTO.PlanningMasterAnnuallyPlan;
					planningMaster.CreatedBy = planningMasterDTO.CreatedBy;
					
					var obj = _PlanningMasterRepo.Insert(planningMaster);
					return Ok(obj);


				//}
				//else if (objCheck != null)
				//{
				//	return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate PlanningMaster!" });
				//}
				//return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
			}
			catch (Exception ex)
			{
				return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
			}
		}
		[HttpGet]
		public ActionResult GetPlanningMasterList()
		{
			try
			{
				var list = (from u in _context.PlanningMasters


							select new { u.PlanningId, u.PlanningName, u.PlanningMasterMonthlyPlan, u.PlanningMasterQuaterlyPlan, u.PlanningMasterHalfYearlyPlan, u.PlanningMasterAnnuallyPlan, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


				int totalRecords = list.Count();


				return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
			}
			catch (Exception ex)
			{
				return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
			}
		}
		//single list
		[HttpGet("{PlanningId}")]
		public ActionResult GetSinglePlanningMaster(int PlanningId)
		{
			try
			{
				var singleImage = _PlanningMasterRepo.SelectById(PlanningId);
				return Ok(singleImage);
			}
			catch (Exception ex)
			{
				return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
			}
		}
		//update
		[HttpPost]
		public ActionResult updatePlanningMaster(UpdatePlanningMasterDTO updatePlanningMasterDTO)
		{
			try
			{
				var objplanningMaster = _context.PlanningMasters.SingleOrDefault(opt => opt.PlanningId == updatePlanningMasterDTO.PlanningId);
				objplanningMaster.PlanningName = updatePlanningMasterDTO.PlanningName;
				objplanningMaster.PlanningMasterMonthlyPlan = updatePlanningMasterDTO.PlanningMasterMonthlyPlan;
				objplanningMaster.PlanningMasterQuaterlyPlan = updatePlanningMasterDTO.PlanningMasterQuaterlyPlan;
				objplanningMaster.PlanningMasterHalfYearlyPlan = updatePlanningMasterDTO.PlanningMasterHalfYearlyPlan;
				objplanningMaster.PlanningMasterAnnuallyPlan = updatePlanningMasterDTO.PlanningMasterAnnuallyPlan;
				objplanningMaster.UpdatedBy = updatePlanningMasterDTO.CreatedBy;
				objplanningMaster.UpdatedOn = System.DateTime.Now;

				_context.SaveChanges();
				return Ok(objplanningMaster);
			}
			catch (Exception ex)
			{
				return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
			}
		}
		[HttpGet("{Id}/{DeletedBy}")]
		public ActionResult DeletePlanningMaster(int Id, int DeletedBy)
		{
			try
			{
				var objplanningMaster = _context.PlanningMasters.SingleOrDefault(opt => opt.PlanningId == Id);
				objplanningMaster.IsDeleted = true;

				objplanningMaster.UpdatedBy = DeletedBy;
				objplanningMaster.UpdatedOn = System.DateTime.Now;


				_context.SaveChanges();
				return Ok(objplanningMaster);
			}
			catch (Exception ex)
			{
				return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
			}
		}
	}
}
