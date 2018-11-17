using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class BOIDefinitionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BOIDefinitionList()
        {
            return View();
        }
        public IActionResult BOIDefinitionRequest()
        {
            return View();
        }
        public IActionResult BOIDefinitionRequestList()
        {
            return View();
        }
        public IActionResult BOIDefinitionUpdate()
        {
            return View();
        }
    }
}