using Microsoft.AspNetCore.Mvc;
using ResortManager1._0.Data;

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
        public IActionResult hjoz()
        {
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
