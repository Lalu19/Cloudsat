using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class JobOpening
    {
        public int JobOpeningId { get; set; }
        public string JobPositionName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Industry { get; set; }
        public string JobType { get; set; }
        public string WorkExperience { get; set; }
        public DateTime DateOpened { get; set; }
        public string JobDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
