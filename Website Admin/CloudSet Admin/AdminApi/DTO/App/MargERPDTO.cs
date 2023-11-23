using System;

namespace AdminApi.DTO.App
{
    public class MargERPDTO
    {
       
        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
       
    }
    public class UpdateMargERPDTO
    {
        public int MargERPId { get; set; }

        public string ImageUpload { get; set; }
        public int CreatedBy { get; set; }
       

    }
}
