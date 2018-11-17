using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult ProjectControl()
        {
            return View();
        }
        public IActionResult ProjectList()
        {
            return View();
        }
    }
}