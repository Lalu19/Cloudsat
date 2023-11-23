using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.DTO.App
{
    public class WebsitepagesDTO
    {
        public int CategoryId { get; set; }
       
        public string Header { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }       
        public int CreatedBy { get; set; }
    }
    public class WebsitePageUpdateDTO {
        public int WebsitePagesId { get; set; }
        public int CategoryId { get; set; }       
        public string Header { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
       
        public int CreatedBy { get; set; }
    }

    public class CategoriesDTO
    {
        public int CategoryId { get; set;}
        public int CreatedBy { get; set; }  

        public List<WebsitepagesDTO> WebsitepagesDTOs { get; set; }
    }

   
   
}
