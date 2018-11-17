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
    public class DeliveryController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<DeliveryController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public DeliveryController(ILogger<DeliveryController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string SavesDeliverylist([FromForm]string Deliveryterm, [FromForm]string Meaning, [FromForm]string AIR, [FromForm]string SEA, [FromForm]string TRUCK)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_deliverylist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_D", "D" + id));
                cmd.Parameters.Add(new SqlParameter("@Deliveryterm", Deliveryterm));
                cmd.Parameters.Add(new SqlParameter("@Meaning", Meaning));
                cmd.Parameters.Add(new SqlParameter("@AIR", AIR));
                cmd.Parameters.Add(new SqlParameter("@SEA", SEA));
                cmd.Parameters.Add(new SqlParameter("@TRUCK", TRUCK));
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