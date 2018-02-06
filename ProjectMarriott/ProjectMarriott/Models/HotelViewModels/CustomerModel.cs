using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMarriott.Models.HotelViewModels
{
    public class CustomerModel
    {

        public int CustomerID { get; set; }

        [DisplayName("First Name: ")]
        public string FirstName { get; set; }

        [DisplayName("Last Name: ")]
        public string LastName { get; set; }

        public AddressModel Address { get; set; }

        public ReservationModel ReservationInfo { get; set; }

        public string EmailAddress { get; set; }
    }
}
