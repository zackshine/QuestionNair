using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionNair.Data;
using QuestionNair.Models;

namespace QuestionNair.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var QList = await _context.Questions
                                   .AsNoTracking()
                                   .Include(q=>q.Options)
                                   .Include(q=>q.Answers)
                                   .ToListAsync();
            return View(QList);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitAnswer(List<UserAnswer> userAnswers)
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
