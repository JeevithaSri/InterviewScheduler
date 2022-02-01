using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewScheduler.Controllers
{
    public class RecruitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCandidate()
        {
            return View();
        }
    }
}
