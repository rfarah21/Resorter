using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
/*        public IActionResult Choose() { 
            return View();
        }*/
        public IActionResult Choose(CondosModel obj)
        {
            IEnumerable<CondosModel> objCondosList = _db.Condos;
            var user = JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserSession"));
            if (user.Equals("none")){
                return View("~/Views/User/logIn.cshtml");
            }
            ViewBag.MyString = user;
            return View(objCondosList);
        }
    }
}
