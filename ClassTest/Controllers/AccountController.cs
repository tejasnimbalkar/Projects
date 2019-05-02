using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassTest.Models;
using Microsoft.AspNetCore.Http;

namespace ClassTest.Controllers
{
    public class AccountController : Controller
    {
        public readonly ApplicationDbContext _db;


        public AccountController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Login student = _db.Login.Where(x => x.UserName == model.UserName && x.Password == model.Password).FirstOrDefault();


            if (student!=null)
            {
                HttpContext.Session.SetString("username", model.UserName);
                return View("Success");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return RedirectToAction("Index","Home");
            } 
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _db.Student.Add(model);
            _db.SaveChanges();
            return View();
        }
    }
}