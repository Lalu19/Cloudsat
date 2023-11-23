using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController] 
     public class ApplicationMasterController : ControllerBase
        {
         private readonly IConfiguration _config;
         private readonly AppDbContext _context;
         private readonly ISqlRepository<ApplicationMaster> _ApplicationMasterRepo;
         public ApplicationMasterController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<ApplicationMaster> ApplicationMasterRepo)

         {
             _config = config;
             _context = context;
             _ApplicationMasterRepo = ApplicationMasterRepo;

         }

         //Create
         [HttpPost]
         public ActionResult CreateApplicationMaster(ApplicationMasterDTO applicationMasterDTO)
         {
             try
             {
                 ApplicationMaster applicationMaster = new ApplicationMaster();

                 applicationMaster.ApplicationMasterName = applicationMasterDTO.ApplicationMasterName;
                 applicationMaster.ApplicationMasterLogo = applicationMasterDTO.ApplicationMasterLogo;
                 applicationMaster.Parent = applicationMasterDTO.Parent;
                 applicationMaster.ApplicationMasterMonthlyPrice = applicationMasterDTO.ApplicationMasterMonthlyPrice;
                 applicationMaster.ApplicationMasterQuarterlyPrice = applicationMasterDTO.ApplicationMasterQuarterlyPrice;
                 applicationMaster.ApplicationMasterHalfyearlyPrice = applicationMasterDTO.ApplicationMasterHalfyearlyPrice;
                 applicationMaster.ApplicationMasterYearlyPrice = applicationMasterDTO.ApplicationMasterYearlyPrice;
                 applicationMaster.packagename=applicationMasterDTO.packagename;
                 applicationMaster.frontpagedisplay=applicationMasterDTO.frontpagedisplay;
                 applicationMaster.CreatedBy = applicationMasterDTO.CreatedBy;
                 applicationMaster.CreatedOn = System.DateTime.Now;
                 var obj = _ApplicationMasterRepo.Insert(applicationMaster);
                 return Ok(obj);
             }
             catch (Exception ex)
             {
                 return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
             }
         }

         //[HttpGet]
         //public ActionResult GetApplicationMasterList()
         //{
         //    try
         //    {
         //        var list = (from u in _context.ApplicationMasters
         //                    select new{u.ApplicationMasterId, u.ApplicationMasterName, u.ApplicationMasterLogo,u.applicationparent, u.ApplicationMasterMonthlyPrice, u.ApplicationMasterQuarterlyPrice, u.ApplicationMasterHalfyearlyPrice, u.ApplicationMasterYearlyPrice,u.packagename,u.frontpagedisplay, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

         //        int totalRecords = list.Count();

         //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
         //    }
         //    catch (Exception ex)
         //    {
         //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
         //    }
         //}

        [HttpGet("{applicationMasterId}")]
        public ActionResult GetAllChildApplicationMasterListByApplicationMasterId(int applicationMasterId)
        {
            var ntree = _context.ApplicationMasters.AsEnumerable().Where(x => x.ApplicationMasterId == applicationMasterId).ToList();

            return Ok(ntree);

        }

        [HttpGet]
        public ActionResult GetAllChildApplicationMasterList()
        {
            var Ttree = _context.ApplicationMasters.AsEnumerable().Where(x => x.IsDeleted == false && x.Parent == null).ToList();

            return Ok(Ttree);

        }


        [HttpGet]
        public ActionResult GetApplicationMasterList()
        {
            try
            {
                var list = (from u in _context.ApplicationMasters

                            select new
                            {
                                u.ApplicationMasterId,
                                u.ApplicationMasterLogo,
                                u.ApplicationMasterName,
                                u.ApplicationMasterMonthlyPrice,
                                u.ApplicationMasterQuarterlyPrice,
                                u.ApplicationMasterHalfyearlyPrice,
                                u.ApplicationMasterYearlyPrice,
                                u.IsDeleted,
                                u.Parent,
                                u.packagename,
                                u.frontpagedisplay,

                                ParentName = (u.Parent == null) ? "Primary" :
                            (_context.ApplicationMasters
        .Where(sc => sc.ApplicationMasterId == u.Parent)
        .Select(sc => sc.ApplicationMasterName)
    ).FirstOrDefault()

                            }).Where(x => x.IsDeleted == false).ToList();
                //var list = (from u in _context.Categories where u.IsDeleted == false into g);



                int totalRecords = list.Count();



                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpGet]
        public ActionResult GetAllApplicationMasterList()
        {
            try
            {
                var list = (from u in _context.ApplicationMasters

                            select new
                            {
                                u.ApplicationMasterId,
                                u.ApplicationMasterLogo,
                                u.ApplicationMasterName,
                                u.ApplicationMasterMonthlyPrice,
                                u.ApplicationMasterQuarterlyPrice,
                                u.ApplicationMasterHalfyearlyPrice,
                                u.ApplicationMasterYearlyPrice,
                                u.IsDeleted,
                                u.Parent,
                                u.packagename,
                                u.frontpagedisplay,

                                ParentName = (u.Parent == null) ? "Primary" :
                            (_context.ApplicationMasters
        .Where(sc => sc.ApplicationMasterId == u.Parent)
        .Select(sc => sc.ApplicationMasterName)
    ).FirstOrDefault()

                            }).Where(x => x.IsDeleted == false).ToList();
                //var list = (from u in _context.Categories where u.IsDeleted == false into g);



                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult TreeView()
        {

            return Ok(_context.ApplicationMasters
               .Include(ad=>ad.Children) 
                .Where(x => x.IsDeleted == false).ToList());
        }

        [HttpGet]
        public ActionResult GetParentApplicationMasterList()
        {
            try
            {
                var list = (from u in _context.ApplicationMasters

                            select new
                            {
                                u.ApplicationMasterId,
                                u.ApplicationMasterLogo,
                                u.ApplicationMasterName,
                                u.ApplicationMasterMonthlyPrice,
                                u.ApplicationMasterQuarterlyPrice,
                                u.ApplicationMasterHalfyearlyPrice,
                                u.ApplicationMasterYearlyPrice,
                                u.IsDeleted,
                                u.Parent,
                                u.packagename,
                                u.frontpagedisplay,

                                ParentName = (u.Parent == null) ? "Primary" :
                            (_context.ApplicationMasters
        .Where(sc => sc.ApplicationMasterId == u.Parent)
        .Select(sc => sc.ApplicationMasterName)
    ).FirstOrDefault()

                            }).Where(x => x.IsDeleted == false && x.Parent == null).ToList();
                //var list = (from u in _context.Categories where u.IsDeleted == false into g);



                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{ApplicationMasterId}")]
         public ActionResult GetSingleApplicationMaster(int ApplicationMasterId)
         {
             try
             {
                 var ApplicationMasterLogo = _ApplicationMasterRepo.SelectById(ApplicationMasterId);

                 return Ok(ApplicationMasterLogo);
             }
             catch (Exception ex)
             {
                 return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
             }
         }
         //update
         [HttpPost]
         public ActionResult updateApplicationMaster(UpdateApplicationMasterDTO updateApplicationMasterDTO)
         {
             try
             {
                 var ApplicationMasters = _context.ApplicationMasters.SingleOrDefault(opt => opt.ApplicationMasterId == updateApplicationMasterDTO.ApplicationMasterId);
                 ApplicationMasters.ApplicationMasterName = updateApplicationMasterDTO.ApplicationMasterName;
                 ApplicationMasters.ApplicationMasterLogo = updateApplicationMasterDTO.ApplicationMasterLogo;
                 ApplicationMasters.Parent =updateApplicationMasterDTO.Parent;
                 ApplicationMasters.ApplicationMasterMonthlyPrice = updateApplicationMasterDTO.ApplicationMasterMonthlyPrice;
                 ApplicationMasters.ApplicationMasterQuarterlyPrice = updateApplicationMasterDTO.ApplicationMasterQuarterlyPrice;
                 ApplicationMasters.ApplicationMasterHalfyearlyPrice = updateApplicationMasterDTO.ApplicationMasterHalfyearlyPrice;
                 ApplicationMasters.ApplicationMasterYearlyPrice = updateApplicationMasterDTO.ApplicationMasterYearlyPrice;
                 ApplicationMasters.packagename= updateApplicationMasterDTO.packagename;
                 ApplicationMasters.frontpagedisplay= updateApplicationMasterDTO.frontpagedisplay;
                 ApplicationMasters.UpdatedOn = System.DateTime.Now;

                 _context.SaveChanges();
                 return Ok(ApplicationMasters);
             }
             catch (Exception ex)
             {
                 return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
             }               
         }
         [HttpGet("{Id}/{DeletedBy}")]
         public ActionResult DeleteApplicationMaster(int Id, int DeletedBy)
         {
             try
             {
                 var ApplicationMasters = _context.ApplicationMasters.SingleOrDefault(opt => opt.ApplicationMasterId == Id);
                 ApplicationMasters.IsDeleted = true;

                 ApplicationMasters.UpdatedBy = DeletedBy;
                 ApplicationMasters.UpdatedOn = System.DateTime.Now;


                 _context.SaveChanges();
                 return Ok(ApplicationMasters);
             }
             catch (Exception ex)
             {
                 return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
             }
         }
     }
}
