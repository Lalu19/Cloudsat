namespace AdminApi.DTO.App
{
    public class termsandconditionsDTO
    {
        public string termsandconditionText { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdatetermsandconditionsDTO
    {
        public int termsandconditionsid { get; set; }
        public string termsandconditionText { get; set; }
        public int CreatedBy { get; set; }
    }
}
