﻿using Microsoft.AspNetCore.Mvc;
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
            var test = obj.userbookedId;
            _db.Bookings.Add(obj);
            _db.SaveChanges();
            return View();

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
