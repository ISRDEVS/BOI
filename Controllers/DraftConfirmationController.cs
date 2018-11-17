using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.Controllers
{
    public class DraftConfirmationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShippingNotification()
        {
            return View();
        }
        public IActionResult DraftConfirmation()
        {
            return View();
        }
        public IActionResult HAWBMapping()
        {
            return View();
        }
        public IActionResult DeliveryPlan()
        {
            return View();
        }
    }
}