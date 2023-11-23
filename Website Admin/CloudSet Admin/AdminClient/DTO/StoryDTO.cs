using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.DTO
{
    public class StoryDTO
    {
        public int StoreId { get; set; }
        public string Text { get; set; }
        public List<IFormFile> files { get; set; }
        public int CreatedBy { get; set; }
    }

    public class StoryNewDTO
    {
        public int StoreId { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }
}
