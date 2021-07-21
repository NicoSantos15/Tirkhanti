using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tirkhanti_R12.Models;
using Microsoft.AspNetCore.Identity;
using Tirkhanti_R12.Data;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace Tirkhanti_R12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Tirkhanti_R12Users> _userManager;
        private readonly Tirkhanti_R12Context _db;


        public HomeController(ILogger<HomeController> logger,
            UserManager<Tirkhanti_R12Users> userManager,
            Tirkhanti_R12Context db)
        {
            _logger = logger;
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult ViewAllStudent(bool isActive = true)
        {
            var list = _userManager.Users
                .OrderBy(lname => lname.LastName)
                .OrderBy(fname => fname.FirstName)
                .Select(users => users);

            if (isActive)
            {
                list = list.Where(user => user.IsActive == isActive);
            }
            return View(list);
        }

        public ActionResult ViewMonthly()
        {
            return View();
        }

        // GET: ViewNotification
        public async Task<IActionResult> ViewNotification()
        {
            return View(await _db.StudentReports.ToListAsync());
        }

        // GET: LeaderHome
        public IActionResult LeaderHome()
        {
            dynamic dy = new ExpandoObject();
            dy.emotion = GetEmotions();
            dy.studentreports = GetStudentReports();
            return View(dy);
        }

        public ActionResult NotificationList(bool isComplete = true)
        {
            var list = _db.StudentReports
                        .OrderBy(priority => priority.Priority)
                        .Select(report => report);

            if (isComplete)
            {
                list = list.Where(report => report.IsComplete == isComplete);
            }
            return View(list);
        }

        public ActionResult Confirmation()
        {
            return View(_userManager);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Emotions> GetEmotions()
        {
            List<Emotions> emotions = _db.Emotion.ToList();
            return emotions;
        }

        public List<StudentReport> GetStudentReports()
        {
            List<StudentReport> studentReport = _db.StudentReports.ToList();
            return studentReport;
        }
    }
}
