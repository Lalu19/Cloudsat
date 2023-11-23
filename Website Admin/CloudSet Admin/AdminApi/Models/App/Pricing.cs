using System;

namespace AdminApi.Models.App
{
    public class Pricing
    {
        public int PricingId { get; set; }
        
        public string planes { get; set; }
      
        public string period { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
