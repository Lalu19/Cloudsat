using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class CareersDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int JobOpeningid { get; set; }
        public string Message { get; set; }
        public string ExperienceinYears { get; set; }
        public string Resume { get; set; }
        public string status { get; set; }


    }
    public class UpdateCareersDTO
    {
        public int CareersId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int JobOpeningid { get; set; }
        public string Message { get; set; }
        public string ExperienceinYears { get; set; }
        public string Resume { get; set; }
        public string status { get; set; }

    }
}
