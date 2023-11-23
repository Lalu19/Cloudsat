using System;
using System.ComponentModel.DataAnnotations;

namespace AdminApi.Models.App
{
	
	public class PlanningMaster
	{
		[Key]
		public int PlanningId { get; set; }
		public string PlanningName { get; set; }
		public string PlanningMasterMonthlyPlan { get; set; }
		public string PlanningMasterQuaterlyPlan { get; set; }
		public string PlanningMasterHalfYearlyPlan { get; set; }
		public string PlanningMasterAnnuallyPlan { get; set; }
		public int CreatedBy { get; set; }
		public DateTime? CreatedOn { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedOn { get; set; }
		public bool IsDeleted { get; set; }
	}
}
