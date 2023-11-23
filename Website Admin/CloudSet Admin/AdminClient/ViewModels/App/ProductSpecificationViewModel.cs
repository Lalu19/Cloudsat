using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class ProductSpecificationViewModel
    {
        public int ProductSpecificationId { get; set; }
        public int ProductId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        public ProductViewModel Product { get; set; }
    }
}
