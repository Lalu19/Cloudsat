using System;
using System.ComponentModel.DataAnnotations;

namespace AdminApi.Models.App
{
    public class Homepage
    {
        [Key] 
        public int homeid { get; set; }
        public string ImageUpload { get; set; }
        public string Header { get; set; }
        public string Largecontent { get; set; }
        //public string Description1 { get; set; }
        //public string Description2 { get; set; }
        //public string Description3 { get; set; }
        //public string Description4 { get; set; }
        //public string Description5 { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
