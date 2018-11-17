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
    public class ShipToController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<ShipToController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public ShipToController(ILogger<ShipToController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string SavesShipTolist([FromForm]string Shipto, [FromForm]string Company, [FromForm]string Address, [FromForm]string TAXID, [FromForm]string FullCompany, [FromForm]string FullAddress, [FromForm]string TEL, [FromForm]string FAX)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_shiptolist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_ST", "ST" + id));
                cmd.Parameters.Add(new SqlParameter("@Shipto", Shipto));
                cmd.Parameters.Add(new SqlParameter("@Company", Company));
                cmd.Parameters.Add(new SqlParameter("@Address", Address));
                cmd.Parameters.Add(new SqlParameter("@TAXID", TAXID));
                cmd.Parameters.Add(new SqlParameter("@FullCompany", FullCompany));
                cmd.Parameters.Add(new SqlParameter("@FullAddress", FullAddress));
                cmd.Parameters.Add(new SqlParameter("@TEL", TEL));
                cmd.Parameters.Add(new SqlParameter("@FAX", FAX));
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