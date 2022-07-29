using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ResortManager1._0.Data;

namespace ResortManager1._0.Controllers
{
    public class RealUserController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> userManager;

        public RealUserController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: RealUserController
        public IActionResult Index()
        {
            IEnumerable<IdentityUser> user = _db.Users;
            return View(user);
        }

        // GET: RealUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RealUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RealUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RealUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RealUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RealUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RealUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
