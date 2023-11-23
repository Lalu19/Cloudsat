using System;

namespace AdminApi.Models.App
{
    public class Questions
    {
        public int QuestionsId { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
