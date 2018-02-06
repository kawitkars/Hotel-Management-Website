using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMarriott.Models.HotelViewModels
{
    public class ReservationModel
    {
        public int BookingID { get; set; }

        public List<RoomModel> RoomDetails { get; set; }

        public CustomerModel CustomerDetails { get; set; }

        public DateTime CheckinDateAndTime { get; set; }

        public DateTime CheckoutDateAndTime { get; set; }

        public String AdditionalFacilities { get; set; }

        public int NumberOfAdults { get; set; }
    }
}
