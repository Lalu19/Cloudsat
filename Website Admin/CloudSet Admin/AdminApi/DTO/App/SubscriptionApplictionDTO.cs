using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class SubscriptionApplictionDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string Companysize { get; set; }
        public bool TermsAndconditions { get; set; }
        public string term { get; set; }
        public string Applictions { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateSubscriptionApplictionDTO
    {
        public int SubscriptionApplictionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string Companysize { get; set; }
        public bool TermsAndconditions { get; set; }
        public string term { get; set; }
        public string Applictions { get; set; }
        public int CreatedBy { get; set; }
    }
}
