using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SecondaryCategoryId { get; set; }
        public int TernaryCategoryId { get; set; }
        public double? MRP { get; set; }
        public double? SellingPrice { get; set; }
        public string Unit { get; set; }
        public string ProductDescription { get; set; }
        public bool IsActive { get; set; }
        public bool InStock { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }


       
    }
}
