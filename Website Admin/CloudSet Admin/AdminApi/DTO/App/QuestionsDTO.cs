namespace AdminApi.DTO.App
{
    public class QuestionsDTO
    {
       
        public string question { get; set; }
        public string answer { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateQuestionsDTO
    {
        public int QuestionsId { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int CreatedBy { get; set; }
    }
}
