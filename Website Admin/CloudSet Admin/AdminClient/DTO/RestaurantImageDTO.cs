using Microsoft.AspNetCore.Http;

namespace AdminClient.DTO
{
    public class RestaurantImageDTO
    {
        public int StoreId { get; set; }
        public string ImageType { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int CreatedBy { get; set; }
        public IFormFile file { get; set; }
    }
    public class RestaurantImageNewDTO
    {
        public int StoreId { get; set; }
        public string ImageType { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }
}
