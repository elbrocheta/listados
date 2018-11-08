using GoonListados.Helpers;
using GoonListados.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GoonListados.Controllers
{
    public class RoutersController : Controller
    {
        // GET: Routers
        public ActionResult Index()
        {
            List<DataItem> _list = DataHelper.p_GetData("Routers");

            return View(_list);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            ViewBag.Title = "Routers | Ver >>> " + id.ToString();

            return View();
        }
    }
}