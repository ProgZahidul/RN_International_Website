using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RN_International_Website.Models;
using System.Diagnostics;

namespace RN_International_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        // Single constructor to initialize dependencies
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Index action to fetch team members and pass to the view
        public async Task<IActionResult> Index()
        {
            // Fetch team members from the database
            var teamMembers = await _context.TeamMembers.ToListAsync();
            return View(teamMembers); // Pass data to the Index view
        }

        // Privacy action
        public IActionResult Privacy()
        {
            return View();
        }

        // Error action
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
