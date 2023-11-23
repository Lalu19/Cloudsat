using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminApi.Models.App
{
    public class ApplicationMaster
    {
        public int ApplicationMasterId { get; set; }
        public string ApplicationMasterName { get; set; }
        public string ApplicationMasterLogo { get; set; }
        public int? Parent { get; set; }
        public string ApplicationMasterMonthlyPrice { get; set;}
        public string ApplicationMasterQuarterlyPrice { get; set;}
        public string ApplicationMasterHalfyearlyPrice { get; set;}
        public string ApplicationMasterYearlyPrice { get; set;}
        public string packagename { get; set; }
        public string frontpagedisplay { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ApplicationMaster> Children { get; set; }

    }
}
