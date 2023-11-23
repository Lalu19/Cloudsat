using System;

namespace AdminApi.DTO.App
{
    public class PlanningAndapplicationDTO
    {
        public int ApplicationMasterId { get; set; }
        public int PlanningId { get; set; }

        public int CreatedBy { get; set; }
      
    }
    public class UpdatePlanningandapplicationDTO
    {
        public int planningandapplicationid { get; set; }
        public int ApplicationMasterId { get; set; }
        public int PlanningId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
