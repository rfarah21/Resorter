using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Resort_Management.Models;
using Microsoft.AspNetCore.Session;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ResortManager1._0.Data;

namespace Resort_Management.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<UserModel> objUserList = _db.User;
            return View(objUserList);
        }

        public IActionResult Info()
        {
            var user = JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserSession"));
            ViewBag.MyString = user;
            return View();
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult logIn()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserModel obj)
        {
            _db.User.Add(obj);
            _db.SaveChanges();
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult logIn(UserModel obj)
        {
            var user = obj.Email;
            var pwd = obj.Password;
            var userCheck = _db.User.Find(user);
            if (userCheck != null) {
                if (pwd.Equals(userCheck.Password)) {
                    //Set email into a session key
                    HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(user));
                    return View("~/Views/Home/Index.cshtml");
                }
            }
            return View();
         }
        }
    }

