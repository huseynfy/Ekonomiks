using System;
using System.Linq;
using Ekonomiks.DAL;
using Ekonomiks.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Ekonomiks.Controllers
{
    public class InterviewController : Controller
    {
        private readonly AppDbContext _db;
        public InterviewController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int Id)
        {
            AllViewModel vm = new AllViewModel()
            {
                Contacts = _db.Contacts.FirstOrDefault(contact => contact.Id == 1),
                GetInterview = _db.Interviews.FirstOrDefault(interview => interview.Id == Id),
                Interviews=_db.Interviews.OrderByDescending(x => x.DateTime).Where(x => x.Id != Id)
            };
            return View(vm);
        }
        public IActionResult More(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Interviews.Count() / 12);

            if (page == null)
            {
                ViewBag.Page = 0;
                AllViewModel vm = new AllViewModel()
                {
                    Contacts = _db.Contacts.FirstOrDefault(contact => contact.Id == 1),
                    Interviews = _db.Interviews.Take(12).OrderByDescending(x => x.DateTime)
                };
                return View(vm);
            }
            ViewBag.Page = page;
            AllViewModel vm1 = new AllViewModel()
            {
                Contacts = _db.Contacts.FirstOrDefault(contact => contact.Id == 1),
                Interviews = _db.Interviews.OrderByDescending(x => x.DateTime).Skip(12 * (int)page).Take(12)
            };
            return View(vm1);
        }
        public IActionResult Main(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Interviews.Count() / 6);

            if (page==null)
            {
                ViewBag.Page = 0;
                AllViewModel vm = new AllViewModel()
                {
                    Contacts = _db.Contacts.FirstOrDefault(contact => contact.Id == 1),
                    Interviews = _db.Interviews.OrderByDescending(x => x.DateTime)
                };
                return View(vm);
            }
            ViewBag.Page = page;
            AllViewModel vm1 = new AllViewModel()
            {
                Contacts = _db.Contacts.FirstOrDefault(contact => contact.Id == 1),
                Interviews = _db.Interviews.OrderByDescending(x => x.DateTime).Skip(6 * (int)page)
            };
            return View(vm1);


        }
    }
}