using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.DTO.App
{
    public class ImageDTO
    {
        public int CategoryId { get; set; }
        public string WebsitePages { get; set; }
        public string Largecontent { get; set; }
        public string ImageUpload { get; set; }
        //public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class ImageUpdateDTO
    {
        public int CategoryId { get; set; }
        public string WebsitePages { get; set; }
        public string Largecontent { get; set; }
        public int ImageId { get; set; }
        
        public string ImageUpload { get; set; }
        //public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
}