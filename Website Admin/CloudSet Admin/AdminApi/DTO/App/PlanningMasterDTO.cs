namespace AdminApi.DTO.App
{
	public class PlanningMasterDTO
	{
		
		public string PlanningName { get; set; }
		public string PlanningMasterMonthlyPlan { get; set; }
		public string PlanningMasterQuaterlyPlan { get; set; }
		public string PlanningMasterHalfYearlyPlan { get; set; }
		public string PlanningMasterAnnuallyPlan { get; set; }
		public int CreatedBy { get; set; }
	}
	public class UpdatePlanningMasterDTO
	{
		public int PlanningId { get; set; }
		public string PlanningName { get; set; }
		public string PlanningMasterMonthlyPlan { get; set; }
		public string PlanningMasterQuaterlyPlan { get; set; }
		public string PlanningMasterHalfYearlyPlan { get; set; }
		public string PlanningMasterAnnuallyPlan { get; set; }
		public int CreatedBy { get; set; }
	}
}
