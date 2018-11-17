using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BOIMVC.MyClass
{
    public class SQLClass
    {

     
        string server, user, pass, database;
        string sectionconfigdatabale = "ConfigServerBOI";
      public  string filename ="/Config/Config.ini"; 
        public  string connectionstrin(string filepath)
        {
            server = Inifile.ReadValue(sectionconfigdatabale, "Server", filepath+filename);
            user = Inifile.ReadValue(sectionconfigdatabale, "Username", filepath + filename);
            pass = Inifile.ReadValue(sectionconfigdatabale, "Password", filepath + filename);
            database = Inifile.ReadValue(sectionconfigdatabale, "Database", filepath + filename);
           string connstr = "Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + pass;
            //connstr = "Data Source=192.168.1.128;Initial Catalog=boi_db;User ID=sa;Password=password2*";
            return connstr;
        }
        public int LoadTimeOut(string filepath)
        {
            return Convert.ToInt32(Inifile.ReadValue("ConfigTimeSession", "TimeOut", filepath + filename).ToString());
            
        }
        public DataTable SelectallData(string tablename,string filepath)
        {
            string sqlcmd = "select * from " + tablename;
                DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(connectionstrin(filepath));
            try
            {
              
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd, connection);
              
                dataAdapter.Fill(dataTable);
                connection.Close();
                return dataTable;
               
            } catch(Exception ex)
            {
                connection.Close();
                return dataTable;
            }
                
          
        }

        public bool InsertData(string sqlstring,string filepath)
        {
            SqlConnection connection = new SqlConnection(connectionstrin(filepath));

            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlstring, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }
    }

 
}
