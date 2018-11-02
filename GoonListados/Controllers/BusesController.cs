using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoonListados.Controllers
{
    public class BusesController : Controller
    {
        // GET: Buses
        public ActionResult Index()
        {
            return View();
        }
    }
}