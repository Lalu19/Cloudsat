using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.ViewModels.App
{
    public class ApplicationViewModel
    {
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Application> data { get; set; }
    }
    public class Application
    {
        public int Applicationid { get; set; }
        public string ApplicationName { get; set; }

        public string ApplicationMasterLogo { get; set; }
        public int? parent { get; set; }
        public int? userId { get; set; }

    }
}
