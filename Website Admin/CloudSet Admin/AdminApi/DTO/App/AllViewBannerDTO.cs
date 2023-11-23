namespace AdminApi.DTO.App
{
    public class AllViewBannerDTO
    {
        public int CategoryId { get; set; }

        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateAllViewBannerDTO
    {
        public int ImageId { get; set; }
        public int CategoryId { get; set; }

        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }
}
