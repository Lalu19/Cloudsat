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
    public class JobOpeningController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<JobOpening> _JobOpeningRepo;
        public JobOpeningController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<JobOpening> JobOpeningRepo)

        {
            _config = config;
            _context = context;
            _JobOpeningRepo = JobOpeningRepo;

        }

        [HttpPost]
        public IActionResult JobOpeningCreate(JobOpeningDTO jobOpeningDTO)
        {
            try
            {
                JobOpening job = new JobOpening();
                job.JobPositionName = jobOpeningDTO.JobPositionName;
                job.Country = jobOpeningDTO.Country;
                job.City = jobOpeningDTO.City;
                job.State = jobOpeningDTO.State;
                job.Industry = jobOpeningDTO.Industry;
                job.JobType = jobOpeningDTO.JobType;
                job.WorkExperience = jobOpeningDTO.WorkExperience;
                job.DateOpened = jobOpeningDTO.DateOpened;
                job.JobDescription = jobOpeningDTO.JobDescription;
                job.CreatedBy = jobOpeningDTO.CreatedBy;
                job.CreatedOn = System.DateTime.Now;
                var obj = _JobOpeningRepo.Insert(job);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetJobOpeningList()
        {
            try
            {
                var list = (from u in _context.JobOpening


                            select new
                            {
                                u.JobOpeningId,
                                u.JobPositionName,
                                u.City,
                                u.Country,
                                u.State,
                                u.Industry,
                                u.JobType,
                                u.WorkExperience,
                                u.DateOpened,
                                u.JobDescription,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{jobopeningid}")]
        public ActionResult GetSingleJobOpening(int jobopeningid)
        {
            try
            {
                var singleJobOpening = _JobOpeningRepo.SelectById(jobopeningid);
                return Ok(singleJobOpening);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult updateJobOpening(JobOpeningUpdateDTO jobOpeningUpdateDTO)
        {
            try
            {
                var objjobopening = _context.JobOpening.SingleOrDefault(opt => opt.JobOpeningId == jobOpeningUpdateDTO.JobOpeningId);
                objjobopening.JobPositionName = jobOpeningUpdateDTO.JobPositionName;
                objjobopening.City = jobOpeningUpdateDTO.City;
                objjobopening.Country = jobOpeningUpdateDTO.Country;
                objjobopening.State = jobOpeningUpdateDTO.State;
                objjobopening.Industry = jobOpeningUpdateDTO.Industry;
                objjobopening.JobType = jobOpeningUpdateDTO.JobType;
                objjobopening.WorkExperience = jobOpeningUpdateDTO.WorkExperience;
                objjobopening.DateOpened = jobOpeningUpdateDTO.DateOpened;
                objjobopening.JobDescription = jobOpeningUpdateDTO.JobDescription;
                objjobopening.City = jobOpeningUpdateDTO.City;
                objjobopening.UpdatedBy = jobOpeningUpdateDTO.UpdatedBy;
                objjobopening.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objjobopening);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteJobOpening(int Id, int DeletedBy)
        {
            try
            {
                var objJobopening = _context.JobOpening.SingleOrDefault(opt => opt.JobOpeningId == Id);
                objJobopening.IsDeleted = true;
                objJobopening.UpdatedBy = DeletedBy;
                objJobopening.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objJobopening);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
