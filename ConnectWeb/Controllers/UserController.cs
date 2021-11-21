using ConnectWeb.Data;
using ConnectWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly ConnectDbContext _db;

        public UserController(ConnectDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<User> objUserList = _db.users.ToList();
            return View(objUserList);
        }

        //Get
        public IActionResult Create()
        {          
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            _db.users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
