using System;
namespace AdminApi.Models.App
{
    public class Image
    {
        public int ImageId { get; set; }
        public int CategoryId { get; set; }
        public string WebsitePages { get; set; }
        public string Largecontent { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
