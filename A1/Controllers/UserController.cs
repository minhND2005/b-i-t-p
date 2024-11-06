using A1.Models;
using Microsoft.AspNetCore.Mvc;

namespace A1.Controllers
{
    public class UserController : Controller
    {
        BaiTapDbContext _db;
        public UserController(BaiTapDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(Guid id)
        {
            var user = _db.Users.ToList();
            return View(user);
        }
        [HttpGet]
        public IActionResult Create(Guid id) {
            var user = _db.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var user = _db.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Delete(User user)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var user = _db.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var user = _db.Users.Find(id);
            return View(user);
        }


    }
}
