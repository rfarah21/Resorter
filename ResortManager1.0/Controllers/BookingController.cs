using Microsoft.AspNetCore.Mvc;
using ResortManager1._0.Data;
using Resort_Management.Models;

namespace Resort_Management.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookingController(ApplicationDbContext db)
        {
            _db = db;
        }
        //GET
       public IActionResult Choose()
        {
            string user = Request.Cookies["email"];
            ViewBag.MyString = user;
            return View();
        }
        public IActionResult Booking()
        {
            IEnumerable<BookingModel> objBookingList = _db.Bookings;
            return View(objBookingList);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Choose(BookingModel obj)
        {
            //var test = obj.userbookedId;
            _db.Bookings.Add(obj);
            _db.SaveChanges();
            return View();

        }

        public IActionResult remove()
        {
            IEnumerable<BookingModel> objBookingList = _db.Bookings;
            return View(objBookingList);
        }

        public IActionResult rmBooking(int? id)
        {
            var BookingFromDb = _db.Bookings.Find(id);
            if (BookingFromDb == null)
            {
                return NotFound();
            }
            return View(BookingFromDb);
        }
        [HttpPost, ActionName("rmBooking")]
        [ValidateAntiForgeryToken]
        public IActionResult rmBookingPOST(int? id)
        {
            var BookingFromDb = _db.Bookings.Find(id);
            if (BookingFromDb == null)
            {
                return NotFound();
            }

/*            //get dropdown selected value and store in a variable 
            var eventId = dropdown.SelectedValue;

            //pass this variable in the GetDaysForEvents method to get DataSet.
            var dataSet = GetDaysForEvents(eventId); Possible solution to the problem of using select tag*/

            _db.Bookings.Remove(BookingFromDb);
            _db.SaveChanges();
            return RedirectToAction("Remove");
        }
        /*        [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult hjoz(BookingModel obj)
                {
                    {
                        _db.Booking.Add(obj);
                        _db.SaveChanges();
                        return View();
                    }
                }
            }*/
    }
}
