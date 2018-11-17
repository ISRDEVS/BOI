using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InvoiceRegistration()
        {
            return View();
        }
        public IActionResult Privilege()
        {
            return View();
        }
        public IActionResult InvoiceDescription()
        {
            return View();
        }
    }
}