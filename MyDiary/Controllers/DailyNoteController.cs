using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace MyDiary.Controllers
{
    public class DailyNoteController : Controller
    {
        private IDailyNotesDAL _dal;

        public DailyNoteController() : this(new DailyNotesDAL())
        {
        }

        public DailyNoteController(IDailyNotesDAL dal)
        {
            _dal = dal;
        }
        public IActionResult Index()
        {
            return View("Index",_dal.GetAllDailyNotes());
        }
    }
}