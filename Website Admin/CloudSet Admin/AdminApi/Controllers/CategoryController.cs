using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Category> _categoryRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public CategoryController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Category> categoryRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _categoryRepo = categoryRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateCategory(CategoryDTO categoryDTO)
        {
            var objCheck = _context.Categories.SingleOrDefault(opt => opt.CategoryName == categoryDTO.name && opt.IsDeleted == false && opt.Parent == categoryDTO.Parent);
            try
            {
                if (objCheck == null)
                {

                    Category category = new Category();
                    category.CategoryName = categoryDTO.name;
                    category.CreatedBy = categoryDTO.createdBy;
                    category.Parent = categoryDTO.Parent;

                    category.Order = categoryDTO.Order;

                    category.Icon = categoryDTO.icon;

                    category.IsActive = true;


                    var obj = _categoryRepo.Insert(category);
                    return Ok(obj);


                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Category!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




        [HttpGet("{CategoryId}")]
        public ActionResult GetAllChildCategoryListByCategoryId(int CategoryId)
        {
            var ntree = _context.Categories.AsEnumerable().Where(x => x.CategoryId == CategoryId).ToList();

            return Ok(ntree);

        }

        [HttpGet]
        public ActionResult GetAllChildCategoryList()
        {
            var Ttree = _context.Categories.AsEnumerable().Where(x => x.IsDeleted == false && x.Parent == null).ToList();

            return Ok(Ttree);

        }


        [HttpGet]
        public ActionResult GetCategoryList()
        {
            try
            {
                var list = (from u in _context.Categories

                            select new
                            {
                                u.CategoryId,
                                u.CategoryName,
                                u.Icon,
                                u.IsDeleted,
                                u.Parent,
                             
                                u.IsActive,
                                u.Order,
                            
                                ParentName = (u.Parent == null) ? "Primary" :
                            (_context.Categories
        .Where(sc => sc.CategoryId == u.Parent)
        .Select(sc => sc.CategoryName)
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
        public ActionResult TreeView()
        {

            return Ok(_context.Categories.Where(x => !x.Parent.HasValue).ToList());
        }

        [HttpGet]
        public ActionResult GetParentCategoryList()
        {
            try
            {
                var list = (from u in _context.Categories

                            select new
                            {
                                u.CategoryId,
                                u.CategoryName,
                                u.Icon,
                                u.IsDeleted,
                                u.Parent,
                               
                                u.IsActive,
                                u.Order,
                             
                                ParentName = (u.Parent == null) ? "Primary" :
                            (_context.Categories
        .Where(sc => sc.CategoryId == u.Parent)
        .Select(sc => sc.CategoryName)
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


        [HttpGet("{CategoryId}")]
        public ActionResult GetOnlySubCategoryListByParent(int CategoryId)
        {
            try
            {
                var list = (from u in _context.Categories

                            select new
                            {
                                u.CategoryId,
                                u.CategoryName,
                                u.Icon,
                                u.IsDeleted,
                                u.Parent,
                                u.IsActive,
                                u.Order,
                               
                                ParentName = (u.Parent != null && u.Parent == CategoryId) ? "Primary" :
                            (_context.Categories.Where(sc => sc.CategoryId == u.Parent).Select(sc => sc.CategoryName)).FirstOrDefault()

                            }).Where(x => x.IsDeleted == false && x.Parent != null && x.Parent == CategoryId).ToList();

                //var list = (from u in _context.Category where u.IsDeleted == false into g);

                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpGet("{CategoryId}")]
        public ActionResult GetAllChildCategoryListByParentCategory(int CategoryId)
        {
            var tree = _context.Categories.AsEnumerable().Where(e => e.Parent == CategoryId && e.IsDeleted==false).ToList();



            return Ok(tree);

        }

        [HttpGet("{categoryid}")]
        public ActionResult GetWebsitepagesListbyCategoryId(int categoryid)
        {
            try
            {
                var list = (from u in _context.Websitepages

                            select new { u.WebsitePagesId, u.CategoryId, u.Header, u.Description, u.Description1, u.Description2, u.Description3, u.Description4, u.Description5, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CategoryId == categoryid).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetActiveCategoryList()
        {
            try
            {
                var list = (from u in _context.Categories

                            select new
                            {
                                u.CategoryId,
                                u.CategoryName,
                                u.Icon,
                                u.IsDeleted,
                                u.Parent,
                                
                                u.IsActive,
                                u.Order,
                              
                                ParentName = (u.Parent == 0) ? "Primary" :
                            (_context.Categories
        .Where(sc => sc.CategoryId == u.Parent)
        .Select(sc => sc.CategoryName)
    ).FirstOrDefault()

                            }).Where(x => x.IsDeleted == false && x.IsActive == true).ToList();
                //var list = (from u in _context.Categories where u.IsDeleted == false into g);



                int totalRecords = list.Count();



                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleCategory(int id)
        {
            try
            {
                var singleCategory = _categoryRepo.SelectById(id);
                return Ok(singleCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateCategory(CategoryUpdateDTO categoryUpdateDTO)
        {
            try
            {
                var objCategory = _context.Categories.SingleOrDefault(opt => opt.CategoryId == categoryUpdateDTO.CategoryId);
                objCategory.CategoryName = categoryUpdateDTO.name;
                objCategory.Parent = categoryUpdateDTO.Parent;
       
                objCategory.Order = categoryUpdateDTO.Order;
                objCategory.UpdatedBy = categoryUpdateDTO.createdBy;
                objCategory.UpdatedOn = System.DateTime.Now;
             
                if (categoryUpdateDTO.icon != "")
                {
                    objCategory.Icon = categoryUpdateDTO.icon;
                }

                _context.SaveChanges();
                return Ok(objCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult DeleteCategory(CategoryUpdateDTO categoryUpdateDTO)
        {
            try
            {
                var objCategory = _context.Categories.SingleOrDefault(opt => opt.CategoryId == categoryUpdateDTO.CategoryId);
                objCategory.IsDeleted = true;
                objCategory.UpdatedBy = categoryUpdateDTO.createdBy;
                objCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}/{CreatedBy}/{ActiveStatus}")]
        public ActionResult GetActivateDeactivateCategory(int id, int CreatedBy, bool ActiveStatus)
        {
            try
            {
                var objCategory = _context.Categories.SingleOrDefault(opt => opt.CategoryId == id);
                objCategory.IsActive = ActiveStatus;
                objCategory.UpdatedBy = CreatedBy;
                objCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetActiveCategoryListBySearch(string name)
        {
            var list = (from u in _context.Categories

                        select new
                        {
                            u.CategoryId,
                            u.CategoryName,
                            u.Icon,
                            u.IsDeleted,
                            u.Parent,
                            
                            u.IsActive,
                            u.Order,
                            
                            ParentName = (u.Parent == 0) ? "Primary" :
                        (_context.Categories
    .Where(sc => sc.CategoryId == u.Parent)
    .Select(sc => sc.CategoryName)
).FirstOrDefault()

                        }).Where(x => x.IsDeleted == false && x.IsActive == true && EF.Functions.Like(x.CategoryName,"%"+name+"%") && x.Parent == null ).ToList();
            int totalRecords = list.Count();
            return Ok(new {data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        }


    }
}
