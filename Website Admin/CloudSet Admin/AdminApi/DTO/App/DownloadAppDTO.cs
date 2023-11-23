using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class DownloadAppDTO
    {
        public string ApplicationName { get; set; }
        public string ApplicationFile { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateDownloadAppDTO
    {
        public int DownloadAppId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationFile { get; set; }
        public int CreatedBy { get; set; }
    }
}
