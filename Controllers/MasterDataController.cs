using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BOIMVC.MyClass;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Data.SqlClient;
namespace BOIMVC.Controllers
{
  public class MasterDataController : Controller
    {
        SqlConnection conn;
         DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
    ILogger<MasterDataController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;

       

        public MasterDataController(ILogger<MasterDataController> logger, IHostingEnvironment hostEnvironment)
    {
      _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString()+getdate.Minute+getdate.Second;
        }
       //Shiper Function
        public IActionResult Shiper()
    {

            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_Shipper",_hostEnvironment.WebRootPath);
            ViewData["Save"] = false;
            return View(dt);
    }
       
        public string  SaveShiper([FromForm]string OriginCountry, [FromForm]string Shipper, [FromForm]string ShotName, [FromForm]string Address, [FromForm]string CountryCode, [FromForm]string Zipcode, [FromForm]string Airport, [FromForm]string Incoterm, [FromForm]string ShipmentPrivilege, [FromForm]string Description)
        {
            //string sqlcom = "insert into tb_Shipper values('SP" + id + "','" + OriginCountry + "','" + Shipper + "','" + ShotName + "','" + Address + "','" + CountryCode + "','" + Zipcode + "','" + Airport + "','" + Incoterm + "','" + ShipmentPrivilege + "','" + Description + "',0)";
           
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_shiper", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_SP", "SP"+id));
                cmd.Parameters.Add(new SqlParameter("@OriginCountry", OriginCountry));
                cmd.Parameters.Add(new SqlParameter("@Shipper", Shipper));
                cmd.Parameters.Add(new SqlParameter("@ShotName", ShotName));
                cmd.Parameters.Add(new SqlParameter("@Address", Address));
                cmd.Parameters.Add(new SqlParameter("@CountryCode", CountryCode));
                cmd.Parameters.Add(new SqlParameter("@Zipcode", Zipcode));
                cmd.Parameters.Add(new SqlParameter("@Airport", Airport));
                cmd.Parameters.Add(new SqlParameter("@Incoterm", Incoterm));
                cmd.Parameters.Add(new SqlParameter("@ShipmentPrivilege", ShipmentPrivilege));
                cmd.Parameters.Add(new SqlParameter("@Description", Description));
                cmd.ExecuteNonQuery();

                conn.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
         
        }
        public string testpost([FromForm]string OriginCountry)
        {
            return OriginCountry;
        }

        //Calcel Function
        public IActionResult Calcel()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_cancelreason", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Currency()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_currency", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Delivery()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_delivery", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Email()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_emaillist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Forwardder()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_forwarder", _hostEnvironment.WebRootPath);
            return View(dt);
        }


        //Incorrect Function
        public IActionResult Incorrect()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_incorrectlist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public string SaveIncorrect([FromForm]string PROBLEM)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_Incorrect", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_IL", "SP" + id));
                cmd.Parameters.Add(new SqlParameter("@PROBLEM", PROBLEM));
              
                cmd.ExecuteNonQuery();
                conn.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public IActionResult Mode()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_modeoftransport", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Origin()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_originlist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Port()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_portlist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult ProjectMaster()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_projectmaster", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        //Incorrect Function

        public IActionResult Rawmat()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_rawmatteriallist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public string SaveRawmat([FromForm]string byname, [FromForm]string items, [FromForm]string unit, [FromForm]string description_TH, [FromForm]string coordinates1, [FromForm]string coordinates2, [FromForm]string licenseagency, [FromForm]string number, [FromForm]string statistic, [FromForm]string typeslicense)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_rawmat", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_RMT", "SP" + id));
                cmd.Parameters.Add(new SqlParameter("@byname", byname));
                cmd.Parameters.Add(new SqlParameter("@items", items));
                cmd.Parameters.Add(new SqlParameter("@unit", unit));
                cmd.Parameters.Add(new SqlParameter("@description_TH", description_TH));
                cmd.Parameters.Add(new SqlParameter("@coordinates1", coordinates1));
                cmd.Parameters.Add(new SqlParameter("@coordinates2", coordinates2));
                cmd.Parameters.Add(new SqlParameter("@licenseagency", licenseagency));
                cmd.Parameters.Add(new SqlParameter("@number", number));
                cmd.Parameters.Add(new SqlParameter("@statistic", statistic));
                cmd.Parameters.Add(new SqlParameter("@typeslicense", typeslicense));
                cmd.ExecuteNonQuery();
                conn.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public IActionResult Shipto()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_shipto", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult SparePart()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_sparepartlist", _hostEnvironment.WebRootPath);
            return View(dt);
        }
        public IActionResult Term()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_termofpayment", _hostEnvironment.WebRootPath);
            return View(dt);
        }


        //Incorrect Function
        public IActionResult UOM()
        {
            DataTable dt = new DataTable();
            dt = ConDB.SelectallData("tb_uomlist", _hostEnvironment.WebRootPath);
            return View(dt);
        }

        public string SaveUOM([FromForm]string UnitCode,[FromForm]string UnitThaiName, [FromForm]string UnitEnglishName)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_uom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_UL", "SP" + id));
                cmd.Parameters.Add(new SqlParameter("@UnitCode", UnitCode));
                cmd.Parameters.Add(new SqlParameter("@UnitThaiName", UnitThaiName));
                cmd.Parameters.Add(new SqlParameter("@UnitEnglishName", UnitEnglishName));

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