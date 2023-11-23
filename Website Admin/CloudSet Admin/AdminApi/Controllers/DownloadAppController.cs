using AdminApi.Models.App;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DownloadAppController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<DownloadApp> _DownloadAppRepo;
        public DownloadAppController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<DownloadApp> DownloadAppRepo)

        {
            _config = config;
            _context = context;
            _DownloadAppRepo = DownloadAppRepo;

        }

        [HttpPost]
        public ActionResult CreatDownloadApplication(DownloadAppDTO downloadAppDTO)
        {

            try
            {
                DownloadApp downloadApp = new DownloadApp();

                downloadApp.ApplicationName = downloadAppDTO.ApplicationName;
                downloadApp.ApplicationFile = downloadAppDTO.ApplicationFile;
                downloadApp.CreatedBy = downloadAppDTO.CreatedBy;
                downloadApp.CreatedOn = System.DateTime.Now;

                var obj = _DownloadAppRepo.Insert(downloadApp);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //list
        [HttpGet]
        public ActionResult GetDownloadApplicationList()
        {
            try
            {
                var list = (from u in _context.DownloadApps

                            select new
                            {
                                u.DownloadAppId,
                                u.ApplicationName,
                                u.ApplicationFile,
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

        [HttpGet("{DownloadApplicationId}")]
        public ActionResult GetSingleDownloadApplication(int DownloadApplicationId)
        {
            try
            {
                var singleImage = _DownloadAppRepo.SelectById(DownloadApplicationId);
                return Ok(singleImage);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




        [HttpPost]
        public ActionResult updateDownloadApplication(UpdateDownloadAppDTO updateDownloadAppDTO)
        {
            try
            {
                var downloadApplication = _context.DownloadApps.SingleOrDefault(opt => opt.DownloadAppId == updateDownloadAppDTO.DownloadAppId);
                downloadApplication.ApplicationName = updateDownloadAppDTO.ApplicationName;
                downloadApplication.ApplicationFile = updateDownloadAppDTO.ApplicationFile;
                downloadApplication.UpdatedBy = updateDownloadAppDTO.CreatedBy;
                downloadApplication.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(downloadApplication);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteDownloadApplication(int Id, int DeletedBy)
        {
            try
            {
                var downloadApplication = _context.DownloadApps.SingleOrDefault(opt => opt.DownloadAppId == Id);
                downloadApplication.IsDeleted = true;

                downloadApplication.UpdatedBy = DeletedBy;
                downloadApplication.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(downloadApplication);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
