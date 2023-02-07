using Microsoft.AspNetCore.Mvc;
using Mission4_nb348.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_nb348.Controllers
{
    public class OneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalc() // Get method
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalcModel model) // Post method that receives model
        {
            return View();
        }
    }
}
