using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BOIMVC.MyClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BOIMVC.Controllers.MasterDataControllers
{
    public class EmailController : Controller
    {

        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<EmailController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public EmailController(ILogger<EmailController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }


        public IActionResult Index()
        {
            return View();
        }

        public string SavesEmaillist([FromForm]string FWD, [FromForm]string MailAddress, [FromForm]string Badge)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_emaillist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_EL", "EL"+id));
                cmd.Parameters.Add(new SqlParameter("@FWD", FWD));
                cmd.Parameters.Add(new SqlParameter("@MailAddress ",MailAddress));
                cmd.Parameters.Add(new SqlParameter("@Badge",Badge));
                cmd.ExecuteNonQuery();
                conn.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    
    }
}