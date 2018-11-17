using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InvoiceList()
        {
            return View();
        }
        public IActionResult OverAll()
        {
            return View();
        }
        public IActionResult TestView()
        {
            return View();
        }
    }
}