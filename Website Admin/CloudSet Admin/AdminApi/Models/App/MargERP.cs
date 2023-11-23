using System;

namespace AdminApi.Models.App
{
    public class MargERP
    {
        public int MargERPId { get; set; }
      
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
