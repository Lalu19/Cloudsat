namespace AdminApi.DTO.App
{
    public class BestFeaturedProductsDTO
    {
        public string Header { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateBestFeaturedProductsDTO
    {
        public int BestFeaturedProductsId { get; set; }
        public string Header { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
    }
}
