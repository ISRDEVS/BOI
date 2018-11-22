using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BOIMVC.MyClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;

namespace BOIMVC.Controllers.MasterDataControllers
{
    public class ShiperController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<ShiperController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public ShiperController(ILogger<ShiperController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
         conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public string  SaveShiper([FromForm]string OriginCountry, [FromForm]string Shipper, [FromForm]string ShotName, [FromForm]string Address, [FromForm]string CountryCode, [FromForm]string Zipcode, [FromForm]string Airport, [FromForm]string Incoterm, [FromForm]string ShipmentPrivilege, [FromForm]string Description)
        {
            //string sqlcom = "insert into tb_Shipper values('SP" + id + "','" + OriginCountry + "','" + Shipper + "','" + ShotName + "','" + Address + "','" + CountryCode + "','" + Zipcode + "','" + Airport + "','" + Incoterm + "','" + ShipmentPrivilege + "','" + Description + "',0)";
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
        public String DeleteShiper(string id){
conn=new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
try{
conn.Open();
SqlCommand command= new SqlCommand("sp_delete_shiper",conn);
command.CommandType=CommandType.StoredProcedure;
command.Parameters.Add(new SqlParameter("id_SP",id));
command.ExecuteNonQuery();
conn.Close();
return "OK";
} catch (Exception ex){
return ex.Message.ToString();
}
        }
          public IActionResult GetdataupdateShiper(string id_SP){
            conn.Open();
            SqlDataAdapter dataAdapter= new SqlDataAdapter();
            DataTable dt =new DataTable();
            SqlCommand cmd =new SqlCommand("sp_fild_shiper",conn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("id_SP",id_SP));
            dataAdapter.SelectCommand=cmd;
            dataAdapter.Fill(dt);
            if(dt.Rows.Count>0){
           ViewData["DataShiperUpdate"]="OK";
            } else {
              ViewData["DataShiperUpdate"]="FAIL";
            }
                ViewData["DataShiperUpdate"]="OK";
return View("Shiper");
              
          }
    }

  
}