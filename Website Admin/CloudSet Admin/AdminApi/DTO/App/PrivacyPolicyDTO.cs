namespace AdminApi.DTO.App
{
    public class PrivacyPolicyDTO
    {
     
        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdatePrivacyPolicyDTO
    {
        public int PrivacyPolicyid { get; set; }
        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }
}
