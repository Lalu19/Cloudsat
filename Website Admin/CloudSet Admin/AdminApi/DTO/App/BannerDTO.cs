
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class BannerDTO
    {

        public string ImageUpload { get; set; }

        public int CreatedBy { get; set; }
       
    }
    public class UpdatebanerDTO
    {
        public int bannerId { get; set; }
        public string ImageUpload { get; set; }

        public int CreatedBy { get; set; }

    }

}
