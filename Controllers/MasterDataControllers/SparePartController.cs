using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using BOIMVC.MyClass;
using Microsoft.Extensions.Logging;

namespace BOIMVC.Controllers.MasterDataControllers
{
    public class SparePartController : Controller
    {
        SqlConnection conn;
        DateTime getdate = DateTime.Now;
        string id;
        public SQLClass ConDB = new SQLClass();
        ILogger<SparePartController> _logger;
        private readonly IHostingEnvironment _hostEnvironment;



        public SparePartController(ILogger<SparePartController> logger, IHostingEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            id = getdate.Year.ToString() + getdate.Month.ToString() + getdate.Day.ToString() + getdate.Hour.ToString() + getdate.Minute.ToString() + getdate.Minute + getdate.Second;
        }
        public IActionResult Index()
        {
            return View();
        }

        public string SavesParePart([FromForm]string ITEM, [FromForm]string BOI, [FromForm]string DESCRIPTION, [FromForm]string itemtype, [FromForm]string DESCRIPTION_TH, [FromForm]string Machine, [FromForm]string Unit, [FromForm]string flag_BOM, [FromForm]string article, [FromForm]string condition,[FromForm]string processeMT_1, [FromForm]string processeMT_2, [FromForm]string Typessteps, [FromForm]string Processname, [FromForm]string ProcessDetails, [FromForm]string EMTproductnumber)
        {
            conn = new SqlConnection(ConDB.connectionstrin(_hostEnvironment.WebRootPath));
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_save_sparepart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_SP", "SP" + id));
                cmd.Parameters.Add(new SqlParameter("@ITEM", ITEM));
                cmd.Parameters.Add(new SqlParameter("@BOI", BOI));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", DESCRIPTION));
                cmd.Parameters.Add(new SqlParameter("@itemtype", itemtype));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION_TH", DESCRIPTION_TH));
                cmd.Parameters.Add(new SqlParameter("@Machine", Machine));
                cmd.Parameters.Add(new SqlParameter("@Unit", Unit));
                cmd.Parameters.Add(new SqlParameter("@flag_BOM", flag_BOM));
                cmd.Parameters.Add(new SqlParameter("@article", article));
                cmd.Parameters.Add(new SqlParameter("@condition", condition));
                cmd.Parameters.Add(new SqlParameter("@processeMT_1", processeMT_1));
                cmd.Parameters.Add(new SqlParameter("@processeMT_2", processeMT_2));
                cmd.Parameters.Add(new SqlParameter("@Typessteps", Typessteps));
                cmd.Parameters.Add(new SqlParameter("@Processname", Processname));
                cmd.Parameters.Add(new SqlParameter("@ProcessDetails", ProcessDetails));
                cmd.Parameters.Add(new SqlParameter("@EMTproductnumber", EMTproductnumber));
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