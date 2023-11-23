using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class AboutUsDTO
    {
        public string Text { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
    }
    public class AboutUsUpdateDTO
    {
        public int AboutUsId { get; set; }
        public string Text { get; set; }
        public string ImageUpload { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

