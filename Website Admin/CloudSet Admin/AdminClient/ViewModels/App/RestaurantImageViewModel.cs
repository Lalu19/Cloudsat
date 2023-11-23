using System;

namespace AdminClient.ViewModels.App
{
    public class RestaurantImageViewModel
    {
        public int RestaurantImageId { get; set; }
        public int StoreId { get; set; }
        public string ImageType { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
      
        public bool IsDeleted { get; set; }
    }
    
}
