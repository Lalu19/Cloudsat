using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.DTO
{
    public class ProductDTO
    {
        public int StoreId { get; set; }

        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SecondaryCategoryId { get; set; }
        public int TernaryCategoryId { get; set; }
        public double? MRP { get; set; }
        public double? SellingPrice { get; set; }
        public string Unit { get; set; }
        public string ProductDescription { get; set; }

        public int CreatedBy { get; set; }
       
        public string productSpecificationsDTOs { get; set; }
        public List<IFormFile> files { get; set; }
    }
    public class ProductImageDTO
    {

        public string Image { get; set; }


    }
    public class ProductSpecificationsDTO
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class ProductNewDTO
    {
        public int StoreId { get; set; }

        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SecondaryCategoryId { get; set; }
        public int TernaryCategoryId { get; set; }
        public double? MRP { get; set; }
        public double? SellingPrice { get; set; }
        public string Unit { get; set; }
        public string ProductDescription { get; set; }

        public int CreatedBy { get; set; }
        public List<ProductImageDTO> productImageDTOs { get; set; }
        public List<ProductSpecificationsDTO> productSpecificationsDTOs { get; set; }
    }
}
