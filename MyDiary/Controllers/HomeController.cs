using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using MyDiary.Models;

namespace MyDiary.Controllers
{
    public class HomeController : Controller
    {
        private IDailyNotesDAL _dal;

        public HomeController(): this(new DailyNotesDAL())
        {
        }

        public HomeController(IDailyNotesDAL dal)
        {
            _dal = dal;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
