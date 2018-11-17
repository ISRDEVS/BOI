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
    public class ForwarderController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<ForwarderController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public ForwarderController(ILogger<ForwarderController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string SavesForwarderlist([FromForm]string MODE, [FromForm]string FreightForwarder, [FromForm]string City, [FromForm]string Country, [FromForm]string NAME, [FromForm]string Position, [FromForm]string Emailaddress, [FromForm]string Officephone, [FromForm]string Fax, [FromForm]string Cellphone)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_forwarderlist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_FD", "FD" + id));
                cmd.Parameters.Add(new SqlParameter("@MODE", MODE));
                cmd.Parameters.Add(new SqlParameter("@FreightForwarder", FreightForwarder));
                cmd.Parameters.Add(new SqlParameter("@City", City));
                cmd.Parameters.Add(new SqlParameter("@Country", Country));
                cmd.Parameters.Add(new SqlParameter("@NAME", NAME));
                cmd.Parameters.Add(new SqlParameter("@Position", Position));
                cmd.Parameters.Add(new SqlParameter("@Emailaddress", Emailaddress));
                cmd.Parameters.Add(new SqlParameter("@Officephone", Officephone));
                cmd.Parameters.Add(new SqlParameter("@Fax", Fax));
                cmd.Parameters.Add(new SqlParameter("@Cellphone", Cellphone));
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