using System;

namespace AdminApi.DTO.App
{
    public class HomepageDTO
    {
       
        public string ImageUpload { get; set; }
        public string Header { get; set; }
        public string Largecontent { get; set; }
        //public string Description1 { get; set; }
        //public string Description2 { get; set; }
        //public string Description3 { get; set; }
        //public string Description4 { get; set; }
        //public string Description5 { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdatehomepageDTO
    {
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
    }
}
