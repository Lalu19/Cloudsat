using System;

namespace AdminApi.Models.App
{
    public class Pricingproduct
    {
        public int PricingproductId { get; set; }
        public int PricingId { get; set; }
        public string productname { get; set; }
        public string price { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
