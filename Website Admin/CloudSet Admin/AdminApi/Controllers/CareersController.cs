using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using AdminApi.Models.App;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareersController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Careers> _CareersRepo;
        public CareersController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Careers> CareersRepo)

        {
            _config = config;
            _context = context;
            _CareersRepo = CareersRepo;

        }
        [HttpPost]
        public IActionResult CareersCreate(CareersDTO careersDTO)
        {
            try
            {
                Careers careers = new Careers();
                careers.Name = careersDTO.Name;
                careers.Email = careersDTO.Email;
                careers.Phone = careersDTO.Phone;
                careers.JobOpeningid = careersDTO.JobOpeningid;
                careers.Message = careersDTO.Message;
                careers.Resume = careersDTO.Resume;
                careers.ExperienceinYears = careersDTO.ExperienceinYears;
                careers.status = "Applyed";

                careers.CreatedOn = System.DateTime.Now;
                var obj = _CareersRepo.Insert(careers);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetCareersList()
        {
            try
            {
                var list = (from u in _context.Careers


                            select new { u.CareersId, u.Name, u.Email, u.Phone, u.JobOpeningid, u.Message, u.Resume, u.ExperienceinYears, u.status, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetCareersListwithjobopening()
        {
            try
            {
                var list = (from u in _context.Careers
                            join r in _context.JobOpening on
                            u.JobOpeningid equals r.JobOpeningId
                            select new
                            {
                                u.CareersId,
                                u.Name,
                                u.Email,
                                u.Phone,
                                u.JobOpeningid,
                                u.Message,
                                u.Resume,
                                u.ExperienceinYears,
                                u.status,
                                r.JobPositionName,
                                r.Country,
                                r.City,
                                r.State,
                                r.Industry,
                                r.JobType,
                                r.DateOpened,
                                r.JobDescription,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsimg = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{CareersId}")]
        public ActionResult GetSingleCareers(int CareersId)
        {
            try
            {
                var singleCareers = _CareersRepo.SelectById(CareersId);
                return Ok(singleCareers);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateCareers(UpdateCareersDTO updateCareersDTO)
        {
            try
            {
                var objabout = _context.Careers.SingleOrDefault(opt => opt.CareersId == updateCareersDTO.CareersId);
                objabout.Name = updateCareersDTO.Name;
                objabout.Email = updateCareersDTO.Email;
                objabout.Phone = updateCareersDTO.Phone;
                objabout.JobOpeningid = updateCareersDTO.JobOpeningid;
                objabout.Message = updateCareersDTO.Message;
                objabout.Resume = updateCareersDTO.Resume;
                objabout.ExperienceinYears = updateCareersDTO.ExperienceinYears;
                objabout.status = updateCareersDTO.status;

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
        public ActionResult DeleteCareers(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Careers.SingleOrDefault(opt => opt.CareersId == Id);
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