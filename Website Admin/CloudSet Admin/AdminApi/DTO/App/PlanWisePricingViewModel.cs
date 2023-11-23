using System.Collections.Generic;

namespace AdminApi.DTO.App
{
    public class PlanWisePricingViewModel
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public string Monthly { get; set; }
        public string Quaterly { get; set; }
        public string Halfyearly { get; set; }
        public string YearLy { get; set; }
        public List<ApplicationsPricing> applicationsPricings { get; set; }
    }
    public class ApplicationsPricing
    {
            public string ApplicationName { get; set; }
        public bool IsAvailable { get; set; }
    }
}
