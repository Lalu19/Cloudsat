using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class ApplicationDisplay
    {

        public int ApplicationMasterId { get; set; }
        public string ApplicationMasterName { get; set; }
        public string ApplicationMasterLogo { get; set; }
        public int? Parent { get; set; }
        public string ApplicationMasterMonthlyPrice { get; set; }
        public string ApplicationMasterQuarterlyPrice { get; set; }
        public string ApplicationMasterHalfyearlyPrice { get; set; }
        public string ApplicationMasterYearlyPrice { get; set; }
        public string packagename { get; set; }
        public string frontpagedisplay { get; set; }
              
        public string ParentName { get; set; }

    }
}
