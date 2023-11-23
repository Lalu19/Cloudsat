using System;
namespace AdminApi.Models.App
{
    public class Websitepages
    {
        public int WebsitePagesId { get; set; }
        public int CategoryId { get; set; }
        
        public string Header { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get;set; }
        public bool IsDeleted { get; set; }
    }
}
