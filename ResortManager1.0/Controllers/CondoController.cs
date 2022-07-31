using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Resort_Management.Models;
using ResortManager1._0.Data;

namespace Resort_Management.Controllers
{
    public class CondoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CondoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CondosModel> objCondosList = _db.Condos;
            return View(objCondosList);
        }

        [HttpGet]
        public async Task<IActionResult> Index(string search)
        {
            ViewData["GetCondoDetails"] = search;
            var condoquery = from x in _db.Condos select x;
            if (!string.IsNullOrEmpty(search))
            {
                condoquery = condoquery.Where(x => x.condosLocation.Contains(search));
            }
            return View(await condoquery.AsNoTracking().ToListAsync());

        }

/*        public IActionResult navigate(BookingModel obj)
        {
            string user = Request.Cookies["email"];
            ViewBag.MyString = user;
            return View("~/Views/Condo/Choose.cshtml");

        }*/

    }
}
