using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectMarriott.Models.HotelViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectMarriott.Controllers
{
    public class HotelController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult CustomerHistory()
        {
            return View("CustomerHistory");
        }

        [Authorize]
        public IActionResult Reservation()
        {
            return View("Reservation");
        }

        [Authorize]
        [HttpPost]
        public IActionResult Reservation(ReservationModel reservationModel)
        {
            return View("Reservation", reservationModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SaveBookingDates(ReservationModel reservationModel)
        {
            return View("Reservation", reservationModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SaveRoomDetails(ReservationModel reservationModel)
        {
            if (ModelState.IsValid)
            {
                reservationModel.RoomDetails = new List<RoomModel>();
                reservationModel.CustomerDetails = new CustomerModel();
                reservationModel.CustomerDetails.Address = new AddressModel();
                if (reservationModel.IsSingleRoom == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.SingleRoom.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.SingleRoom;
                    reservationModel.RoomDetails.Add(roomModel);
                }
                if (reservationModel.IsDoubleRoom == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.DoubleRoom.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.DoubleRoom;
                    reservationModel.RoomDetails.Add(roomModel);
                }
                if (reservationModel.IsDeluxeOneBedroom == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.DeluxeOneBedroomSuite.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.DeluxeOneBedroomSuite;
                    reservationModel.RoomDetails.Add(roomModel);
                }
                if (reservationModel.IsDeluxeTwoBedroom == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.DeluxeTwoBedroomSuite.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.DeluxeTwoBedroomSuite;
                    reservationModel.RoomDetails.Add(roomModel);
                }
                if (reservationModel.IsRoyalSuit == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.RoyalSuit.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.RoyalSuit;
                    reservationModel.RoomDetails.Add(roomModel);
                }
                if (reservationModel.IsKingSuit == true)
                {
                    var roomModel = new RoomModel();
                    roomModel.RoomType = RoomType.KingSuit.ToString();
                    roomModel.RoomTariff = (double)RoomTariff.KingSuit;
                    reservationModel.RoomDetails.Add(roomModel);
                }

                if (reservationModel != null && reservationModel.RoomDetails != null &&
                reservationModel.RoomDetails.Count > 0)
                {
                    double totalCostofBooking = 0.0;

                    foreach (var room in reservationModel.RoomDetails)
                    {
                        totalCostofBooking += room.RoomTariff;
                    }

                    reservationModel.TotalCost = totalCostofBooking;
                }

            }

            return View("Reservation", reservationModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SubmitCustomerData(ReservationModel reservationModel)
        {
            if (ModelState.IsValid)
            {
                //Do nothing currently
                
            }

            return View("Reservation", reservationModel);
        }

        public IActionResult Rooms()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
