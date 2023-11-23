using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using EFCore.BulkExtensions;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Pricing> _PricingRepo;
        private readonly ISqlRepository<Pricingproduct> _PricingproductRepo;
        public PricingController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Pricing> PricingRepo, ISqlRepository<Pricingproduct> PricingproductRepo)

        {
            _config = config;
            _context = context;
            _PricingRepo = PricingRepo;
            _PricingproductRepo = PricingproductRepo;

        }
     
        [HttpPost]
        public ActionResult PricingCreate(PricingDTO pricingDTO)
        {
           var objCheck = _context.Pricings.SingleOrDefault(opt =>opt.planes==pricingDTO.planes && opt.period==pricingDTO.period && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Pricing pricing = new Pricing();
                    
                    pricing.planes = pricingDTO.planes;
                    pricing.period = pricingDTO.period;                    
                    pricing.CreatedBy = pricingDTO.CreatedBy;
                    var obj = _PricingRepo.Insert(pricing);

                    for (int i = 0; i < pricingDTO.PricingproductDTOs.Count; i++)
                    {
                        Pricingproduct pricingproduct = new Pricingproduct();

                        pricingproduct.PricingId = obj.PricingId;
                        pricingproduct.productname = pricingDTO.PricingproductDTOs[i].productname;
                        pricingproduct.price = pricingDTO.PricingproductDTOs[i].price;
                        pricingproduct.CreatedBy = pricingDTO.CreatedBy;

                        var detailsfilterTableobj = _PricingproductRepo.Insert(pricingproduct);
                    }


                    return Ok(pricingDTO);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Filter..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Already Exists!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


      
        [HttpGet]
        public ActionResult GetPricingListWithPricingproducts()
        {
            try
            {
                var list = (from u in _context.Pricings
                           

                            select new
                            { u.PricingId, u.planes, u.period, u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();

                List<PricingViewDTO> pricingViewDTOs = new List<PricingViewDTO>();
                for (int i = 0; i < list.Count; i++)
                {

                    PricingViewDTO pricingViewDTO = new PricingViewDTO();
                    pricingViewDTO.PricingId = list[i].PricingId;
                    pricingViewDTO.planes = list[i].planes;
                    pricingViewDTO.period = list[i].period;
                   
                    pricingViewDTO.CreatedBy = list[i].CreatedBy;

                    var tinDetails = (from u in _context.Pricingproducts

                                      select new
                                      { u.PricingproductId, u.PricingId, u.productname,u.price, u.IsDeleted }).Where(x => x.IsDeleted == false && x.PricingId == list[i].PricingId).ToList();
                    List<PricingproductViewDTO> pricingproductViewDTOs = new List<PricingproductViewDTO>();
                    for (int j = 0; j < tinDetails.Count; j++)
                    {
                        PricingproductViewDTO pricingproductViewDTO = new PricingproductViewDTO();
                        pricingproductViewDTO.PricingproductId = tinDetails[j].PricingproductId;
                        pricingproductViewDTO.PricingId = tinDetails[j].PricingId;
                        pricingproductViewDTO.price = tinDetails[j].price;
                        pricingproductViewDTO.productname = tinDetails[j].productname;

                        pricingproductViewDTOs.Add(pricingproductViewDTO);
                    }
                    pricingViewDTO.PricingproductViewDTOs = pricingproductViewDTOs;
                    pricingViewDTOs.Add(pricingViewDTO);
                }
                int totalRecords = pricingViewDTOs.Count();
                return Ok(new
                {
                    data = pricingViewDTOs,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{Period}")]
        public ActionResult GetPricingListWithPricingproductsbyPreiod(string Period)
        {
            try
            {
                var list = (from u in _context.Pricings

                            select new
                            { u.PricingId, u.planes, u.period, u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.period== Period).ToList();

                List<PricingViewDTO> pricingViewDTOs = new List<PricingViewDTO>();
                for (int i = 0; i < list.Count; i++)
                {

                    PricingViewDTO pricingViewDTO = new PricingViewDTO();
                    pricingViewDTO.PricingId = list[i].PricingId;
                    pricingViewDTO.planes = list[i].planes;
                    pricingViewDTO.period = list[i].period;

                    pricingViewDTO.CreatedBy = list[i].CreatedBy;

                    var tinDetails = (from u in _context.Pricingproducts

                                      select new
                                      { u.PricingproductId, u.PricingId, u.productname, u.price, u.IsDeleted }).Where(x => x.IsDeleted == false && x.PricingId == list[i].PricingId).ToList();
                    List<PricingproductViewDTO> pricingproductViewDTOs = new List<PricingproductViewDTO>();
                    for (int j = 0; j < tinDetails.Count; j++)
                    {
                        PricingproductViewDTO pricingproductViewDTO = new PricingproductViewDTO();
                        pricingproductViewDTO.PricingproductId = tinDetails[j].PricingproductId;
                        pricingproductViewDTO.PricingId = tinDetails[j].PricingId;
                        pricingproductViewDTO.price = tinDetails[j].price;
                        pricingproductViewDTO.productname = tinDetails[j].productname;

                        pricingproductViewDTOs.Add(pricingproductViewDTO);
                    }
                    pricingViewDTO.PricingproductViewDTOs = pricingproductViewDTOs;
                    pricingViewDTOs.Add(pricingViewDTO);
                }
                int totalRecords = pricingViewDTOs.Count();
                return Ok(new
                {
                    data = pricingViewDTOs,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }

       
        //single list
        //[HttpGet("{pricingId}")]
        //public ActionResult GetSinglePricing(int pricingId)
        //{
        //    try
        //    {
        //        var singlepricing = _PricingRepo.SelectById(pricingId);
        //        return Ok(singlepricing);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}


        //single plan list
        [HttpGet("{planes}")]
        public ActionResult GetSingleplan(string planes)
        {
            try
            {
                var singleplan = _context.Pricings.Where(opt => opt.planes == planes && opt.IsDeleted==false).ToList();
                return Ok(singleplan);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{period}")]
        public ActionResult GetSingleperiod(string period)
        {
            try
            {
                var singleplan = _context.Pricings.Where(opt => opt.period == period && opt.IsDeleted == false).ToList();
                return Ok(singleplan);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetPricingList()
        {
            try
            {
                var list = (from u in _context.Pricings


                            select new { u.PricingId, u.planes, u.period, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ////update
        //[HttpPost]
        //public ActionResult updatepricing(UpadatePricingDTO upadatePricingDTO)
        //{
        //    try
        //    {
        //        var objimg = _context.Pricings.SingleOrDefault(opt => opt.PricingId == upadatePricingDTO.PricingId);
        //        objimg.planes = upadatePricingDTO.planes;               
        //        objimg.period = upadatePricingDTO.period;
        //        objimg.UpdatedBy = upadatePricingDTO.CreatedBy;
        //        objimg.UpdatedOn = System.DateTime.Now;

        //        _context.SaveChanges();
        //        return Ok(objimg);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}

        //[HttpGet("{Id}/{DeletedBy}")]
        //public ActionResult DeletePricing(int Id, int DeletedBy)
        //{
        //    try
        //    {
        //        var objimg = _context.Pricings.SingleOrDefault(opt => opt.PricingId == Id);
        //        objimg.IsDeleted = true;

        //        objimg.UpdatedBy = DeletedBy;
        //        objimg.UpdatedOn = System.DateTime.Now;


        //        _context.SaveChanges();
        //        return Ok(objimg);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}

        [HttpGet("{Id}")]
        public ActionResult GetSinglePricing(int Id)
        {
            try
            {
                var list = (from u in _context.Pricings
                            
                            select new
                            { u.PricingId, u.period, u.planes, u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false && x.PricingId == Id).FirstOrDefault();

                var  product = (from u in _context.Pricingproducts
                                   
                                   select new
                                   { u.PricingproductId, u.PricingId, u.productname, u.price, u.IsDeleted }).Where(x => x.IsDeleted == false && x.PricingId == Id).ToList();
                return Ok(new
                {
                    data = list,
                    PricingproductViewDTO = product
                });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public async Task<ActionResult> UpdatepricingAsync(UpadatePricingDTO upadatePricingDTO)
        {
            try
            {
                var obj = _context.Pricings.SingleOrDefault(opt => opt.PricingId == upadatePricingDTO.PricingId);
                obj.planes = upadatePricingDTO.planes;
                obj.period = upadatePricingDTO.period;
                
               
                obj.UpdatedBy = upadatePricingDTO.CreatedBy;
                obj.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                var productTable = (from u in _context.Pricingproducts                                   

                                   select new { u.PricingproductId, u.PricingId, u.price, u.productname, u.IsDeleted }).Where(x => x.IsDeleted == false && x.PricingId == upadatePricingDTO.PricingId).ToList();

                List<Pricingproduct> pricingproductTables = new List<Pricingproduct>();
                for (var i = 0; i < productTable.Count; i++)
                {
                    Pricingproduct productTableTin = new Pricingproduct();
                    productTableTin.PricingproductId = productTable[i].PricingproductId;
                    productTableTin.IsDeleted = true;
                    productTableTin.UpdatedBy = upadatePricingDTO.CreatedBy;
                    productTableTin.UpdatedOn = System.DateTime.Now;
                    pricingproductTables.Add(productTableTin);
                }
                await _context.BulkUpdateAsync(pricingproductTables);

                for (int i = 0; i < upadatePricingDTO.updatepricingproductDTOs.Count; i++)
                {
                    Pricingproduct nproductTable = new Pricingproduct();
                    nproductTable.PricingId = upadatePricingDTO.PricingId;
                    nproductTable.price = upadatePricingDTO.updatepricingproductDTOs[i].price;
                    nproductTable.productname = upadatePricingDTO.updatepricingproductDTOs[i].productname;
                  
                    nproductTable.CreatedBy = upadatePricingDTO.CreatedBy;
                    var detailsfilterTableobj = _PricingproductRepo.Insert(nproductTable);
                }

                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePricing(int Id, int DeletedBy)
        {
            try
            {
                var obj = _context.Pricings.SingleOrDefault(opt => opt.PricingId == Id);
                obj.IsDeleted = true;

                obj.UpdatedBy = DeletedBy;
                obj.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }

    }

}

    
