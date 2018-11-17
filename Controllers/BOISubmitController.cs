using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class BOISubmitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BirtImpCreate()
        {
            return View();
        }
        public IActionResult BOISubmit()
        {
            return View();
        }
        public IActionResult BOIApproval()
        {
            return View();
        }
        public IActionResult BOIApprovalList()
        {
            return View();
        }
    }
}