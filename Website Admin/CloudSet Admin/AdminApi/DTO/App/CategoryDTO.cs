using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class CategoryDTO
    {
        public string name { get; set; }

        public string icon { get; set; }
        public int? Parent { get; set; }

        public int Order { get; set; }
    
        
        public int createdBy { get; set; }
    }

    public class NewCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Parent { get; set; }
        public int? ParentCategoryId { get; set; }
      
        public bool IsActive { get; set; }
        public int Order { get; set; }
    
        public List<NewCategoryDto> newCategoryDtos { get; set; }
    }
    public class CategoryUpdateDTO
    {
        public int CategoryId { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string icon { get; set; }
        public int? Parent { get; set; }

        public int Order { get; set; }
        public int createdBy { get; set; }
    }

    public class CategoryViewDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Parent { get; set; }
      
        public bool IsActive{ get; set; }
        public int Order{ get; set; }


    }
}
