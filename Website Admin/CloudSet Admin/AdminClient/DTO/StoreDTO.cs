using Microsoft.AspNetCore.Http;
using System;

namespace AdminClient.DTO
{
    public class StoreDTO
    {
        public int UserId { get; set; }
        public string StoreName { get; set; }
        public int CategoryId { get; set; }
        public string OwnerName { get; set; }
        public string BusineessContactInfo { get; set; }
        public string BusinessLogo { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public bool IsSundayOpen { get; set; }
        public TimeSpan? SundayOpenTime { get; set; }
        public TimeSpan? SundayCloseTime { get; set; }


        public bool IsMondayOpen { get; set; }
        public TimeSpan? MondayOpenTime { get; set; }
        public TimeSpan? MondayCloseTime { get; set; }


        public bool IsTuesdayOpen { get; set; }
        public TimeSpan? TuesdayOpenTime { get; set; }
        public TimeSpan? TuesdayCloseTime { get; set; }


        public bool IsWednessdayOpen { get; set; }
        public TimeSpan? WednessdayOpenTime { get; set; }
        public TimeSpan? WednessdayCloseTime { get; set; }


        public bool IsThursdayOpen { get; set; }
        public TimeSpan? ThursdayOpenTime { get; set; }
        public TimeSpan? ThursdayCloseTime { get; set; }


        public bool IsFridayOpen { get; set; }
        public TimeSpan? FridayOpenTime { get; set; }
        public TimeSpan? FridayCloseTime { get; set; }


        public bool IsSaturdayOpen { get; set; }
        public TimeSpan? SaturdayOpenTime { get; set; }
        public TimeSpan? SaturdayCloseTime { get; set; }

        public string RefferedBy { get; set; }

        public IFormFile file { get; set; }
    }

    public class StoreNewDTO
    {
        public int UserId { get; set; }
        public string StoreName { get; set; }
        public int CategoryId { get; set; }
        public string OwnerName { get; set; }
        public string BusineessContactInfo { get; set; }
        public string BusinessLogo { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public bool IsSundayOpen { get; set; }
        public TimeSpan? SundayOpenTime { get; set; }
        public TimeSpan? SundayCloseTime { get; set; }


        public bool IsMondayOpen { get; set; }
        public TimeSpan? MondayOpenTime { get; set; }
        public TimeSpan? MondayCloseTime { get; set; }


        public bool IsTuesdayOpen { get; set; }
        public TimeSpan? TuesdayOpenTime { get; set; }
        public TimeSpan? TuesdayCloseTime { get; set; }


        public bool IsWednessdayOpen { get; set; }
        public TimeSpan? WednessdayOpenTime { get; set; }
        public TimeSpan? WednessdayCloseTime { get; set; }


        public bool IsThursdayOpen { get; set; }
        public TimeSpan? ThursdayOpenTime { get; set; }
        public TimeSpan? ThursdayCloseTime { get; set; }


        public bool IsFridayOpen { get; set; }
        public TimeSpan? FridayOpenTime { get; set; }
        public TimeSpan? FridayCloseTime { get; set; }


        public bool IsSaturdayOpen { get; set; }
        public TimeSpan? SaturdayOpenTime { get; set; }
        public TimeSpan? SaturdayCloseTime { get; set; }

        public string RefferedBy { get; set; }
    }
}
