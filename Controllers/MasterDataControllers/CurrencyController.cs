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
    public class CurrencyController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<CurrencyController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public CurrencyController(ILogger<CurrencyController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string SavesCurrencylist([FromForm]string CurrencyCode, [FromForm]string Description, [FromForm]string CountryTH, [FromForm]string CurrencyTH)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_currencylist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_C", "C" + id));
            cmd.Parameters.Add(new SqlParameter("@CurrencyCode", CurrencyCode));
                cmd.Parameters.Add(new SqlParameter("@Description", Description));
                cmd.Parameters.Add(new SqlParameter("@CountryTH", CountryTH));
                cmd.Parameters.Add(new SqlParameter("@CurrencyTH", CurrencyTH));
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