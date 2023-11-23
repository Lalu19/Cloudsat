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
    public class HomePageController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Homepage> _HomepageRepo;
        public HomePageController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Homepage> HomepageRepo)

        {
            _config = config;
            _context = context;
            _HomepageRepo = HomepageRepo;

        }
        //create
        [HttpPost]
        public ActionResult HomepageCreate(HomepageDTO homepageDTO)
        {

            try
            {
                Homepage homepage = new Homepage();

                homepage.Header=homepageDTO.Header;
                homepage.ImageUpload = homepageDTO.ImageUpload;
                homepage.Largecontent = homepageDTO.Largecontent;
                //  homepage.Description1 = homepageDTO.Description1;
                //  homepage.Description2 = homepageDTO.Description2;
                //  homepage.Description3 = homepageDTO.Description3;
                // homepage.Description4 = homepageDTO.Description4;
                // homepage.Description5 = homepageDTO.Description5;
                homepage.CreatedBy = homepageDTO.CreatedBy;
                homepage.CreatedOn = System.DateTime.Now;
                var obj = _HomepageRepo.Insert(homepage);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetHomepageList()
        {
            try
            {
                var list = (from u in _context.Homepages


                            select new { u.homeid,u.Header, u.Largecontent,/*u.Description,u.Description1,u.Description2,u.Description3,u.Description4,u.Description5,*/ u.ImageUpload, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{homeid}")]
        public ActionResult GetSingleHomepage(int homeid)
        {
            try
            {
                var singleImage = _HomepageRepo.SelectById(homeid);
                return Ok(singleImage);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        //update
        [HttpPost]
        public ActionResult updateHomepages(UpdatehomepageDTO updatehomepageDTO)
        {
            try
            {
                var objimg = _context.Homepages.SingleOrDefault(opt => opt.homeid == updatehomepageDTO.homeid);
                objimg.Header = updatehomepageDTO.Header;
                objimg.ImageUpload = updatehomepageDTO.ImageUpload;
                objimg.Largecontent = updatehomepageDTO.Largecontent;
                // objimg.Description1 = updatehomepageDTO.Description1;
                // objimg.Description2 = updatehomepageDTO.Description2;
                // objimg.Description3 = updatehomepageDTO.Description3;
                // objimg.Description4 = updatehomepageDTO.Description4;
                // objimg.Description5 = updatehomepageDTO.Description5;
                objimg.UpdatedBy = updatehomepageDTO.CreatedBy;
                objimg.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(objimg);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteHomepage(int Id, int DeletedBy)
        {
            try
            {
                var objimg = _context.Homepages.SingleOrDefault(opt => opt.homeid == Id);
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

