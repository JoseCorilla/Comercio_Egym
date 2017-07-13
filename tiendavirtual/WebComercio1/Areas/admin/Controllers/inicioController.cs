using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComercio1.Areas.admin.Controllers
{
    public class inicioController : Controller
    {
        // GET: admin/inicio
        public ActionResult Index()
        {
            return View();
        }
    }
}