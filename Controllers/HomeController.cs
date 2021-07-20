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

namespace Tirkhanti_R12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Tirkhanti_R12Users> _userManager;
        private IEnumerable<Emotions> _emotion;
        private readonly Tirkhanti_R12Context _db;


        public HomeController(ILogger<HomeController> logger,
            UserManager<Tirkhanti_R12Users> userManager,
           IEnumerable<Emotions> emotion,
            Tirkhanti_R12Context db)
        {
            _logger = logger;
            _userManager = userManager;
            _db = db;
            _emotion = emotion;
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
            return View(await _db.StudentReport.ToListAsync());
        }

        // GET: LeaderHome
        public async Task<IActionResult> LeaderHome()
        {
            return View(await _db.Emotion.ToListAsync());
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
    }
}
