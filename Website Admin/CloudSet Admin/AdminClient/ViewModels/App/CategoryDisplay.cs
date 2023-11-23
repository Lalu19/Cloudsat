using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class CategoryDisplay
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public int? Parent { get; set; }
      
        public bool IsActive { get; set; }
        public int? Order { get; set; }
       
        public string ParentName { get; set; }
    }
}
