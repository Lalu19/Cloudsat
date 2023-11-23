using System;

namespace AdminApi.ViewModels.User
{
    public class UserInfo
    {
        public int UserId { get; set; }	
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }
		public string FullName { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}