namespace AdminApi.DTO.App
{
    public class BetterProductDTO
    {
        public string Text { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateBetterProductDTO
    {
        public int BetterProductId { get; set; }
        public string Text { get; set; }
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
    }

}
