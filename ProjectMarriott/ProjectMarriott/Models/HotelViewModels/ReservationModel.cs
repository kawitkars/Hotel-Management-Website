using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMarriott.Models.HotelViewModels
{
    public class ReservationModel
    {
        public int BookingID { get; set; }

        public List<RoomModel> RoomDetails { get; set; }

        public CustomerModel CustomerDetails { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckinDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckoutDate { get; set; }

        public String AdditionalFacilities { get; set; }

        [Required]
        public int NumberOfAdults { get; set; }

        [Required]
        public int NumberOfChildren { get; set; }

        public bool IsSingleRoom { get; set; }

        public bool IsDoubleRoom { get; set; }

        public bool IsDeluxeOneBedroom { get; set; }

        public bool IsDeluxeTwoBedroom { get; set; }

        public bool IsRoyalSuit { get; set; }

        public bool IsKingSuit { get; set; }

        public double TotalCost { get; set; }
    }
}
