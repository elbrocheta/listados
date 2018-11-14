using GoonListados.Helpers;
using GoonListados.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoonListados.Controllers
{
    public class SimsController : Controller
    {
        // GET: Sims
        public ActionResult Index()
        {
            //List<DataItem> _list = DataHelper.p_GetData("Sims");
            List<DataItem> _list = new List<DataItem>();

            String _s = ConfigurationManager.ConnectionStrings["ConnectionDefault"].ConnectionString;

            SqlConnection _conn = new SqlConnection(_s);
            SqlCommand _command = new SqlCommand("SELECT * FROM Noticias", _conn);

            _conn.Open();           

            SqlDataReader _dr = _command.ExecuteReader();

            while (_dr.Read()) {

                _list.Add(new DataItem() {
                    datos1 =  _dr.GetValue(0).ToString(),
                    datos2 = _dr.GetValue(1).ToString(),
                    datos3 = _dr.GetValue(2).ToString(),
                    datos4 = _dr.GetValue(3).ToString(),
                    datos5 = "<< sin datos >>",
                    datos6 = "<< sin datos >>"

                });
            }

                _conn.Close();

            return View(_list);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            ViewBag.Title = "Sims | Ver >>> " + id.ToString();

            return View();
        }
    }
}