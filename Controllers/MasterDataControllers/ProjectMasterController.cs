using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BOIMVC.MyClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BOIMVC.Controllers.MasterDataControllers
{
    public class ProjectMasterController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<ProjectMasterController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public ProjectMasterController(ILogger<ProjectMasterController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}