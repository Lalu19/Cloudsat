using System;
using System.ComponentModel.DataAnnotations;

namespace AdminApi.Models.App
{
    public class AllViewBanner
    {
        [Key]
        public int ImageId { get; set; }
        public int CategoryId { get; set; }
       
        public string Text { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
