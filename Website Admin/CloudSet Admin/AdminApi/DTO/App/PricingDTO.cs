using System;
using System.Collections.Generic;

namespace AdminApi.DTO.App
{
    public class PricingDTO
    {

        public string planes { get; set; }
        
        public string period { get; set; }
        public int CreatedBy { get; set; }

        public List<pricingproductDTO> PricingproductDTOs { get; set; }
    }
    public class pricingproductDTO
    {
        public int PricingId { get; set; }
        public string price { get; set; }
        public string productname { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpadatePricingDTO
    {
        public int PricingId { get; set; }
        public string planes { get; set; }
      
        public string period { get; set; }
        public int CreatedBy { get; set; }

        public List<updatepricingproductDTO> updatepricingproductDTOs { get; set; }
    }
    public class updatepricingproductDTO
    {
        public int PricingproductId { get; set; }
        public int PricingId { get; set; }
        public string price { get; set; }
        public string productname { get; set; }
        public int CreatedBy { get; set; }
    }
    public class PricingViewDTO
    {
        public int PricingId { get; set; }
        public string planes { get; set; }
        
        public string period { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public List<PricingproductViewDTO> PricingproductViewDTOs { get; set; }
    }
    public class PricingproductViewDTO
    {
        public int PricingproductId { get; set; }
        public int PricingId { get; set; }
        public string price { get; set; }
        public string productname { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
