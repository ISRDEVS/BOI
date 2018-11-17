using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class InPlantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StoreReceive()
        {
            return View();
        }
        public IActionResult ReceiveBill()
        {
            return View();
        }
        public IActionResult ReceiveUpdate()
        {
            return View();
        }
    }
}