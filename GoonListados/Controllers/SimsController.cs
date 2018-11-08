using GoonListados.Helpers;
using GoonListados.Models;
using System;
using System.Collections.Generic;
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
            List<DataItem> _list = DataHelper.p_GetData("Sims");

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