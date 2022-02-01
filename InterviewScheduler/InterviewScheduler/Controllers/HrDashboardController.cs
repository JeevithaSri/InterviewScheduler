using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewScheduler.Controllers
{
    public class HrDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
