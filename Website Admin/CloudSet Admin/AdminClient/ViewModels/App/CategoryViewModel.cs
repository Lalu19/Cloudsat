using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class CategoryViewModel
    {
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Categories> data { get; set; }
    }
    public class Categories
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
   
        public string icon { get; set; }
        public int? parent { get; set; }
        public int? userId { get; set; }
     
    }
}
