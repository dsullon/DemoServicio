using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoServicio.Controllers
{
    public class HomeController : Controller
    {
        FootballWS.InfoSoapTypeClient proxy = new FootballWS.InfoSoapTypeClient("InfoSoap");
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teams()
        {
            var listado = proxy.Teams().ToList();
            return View(listado);
        }
    }
}