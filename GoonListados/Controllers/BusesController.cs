using GoonListados.Helpers;
using GoonListados.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GoonListados.Controllers
{
    public class BusesController : Controller
    {
        // GET: Buses
        public ActionResult Index()
        {
            List<DataItem> _list = DataHelper.p_GetData("Buses");

            return View(_list);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            ViewBag.Title = "Buses | Ver >>> " + id.ToString();

            return View();
        }
    }
}