using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComercio1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Carrito()
        {
            return View();
        }
        public ActionResult Rivisar()
        {
            return View();
        }
        public ActionResult Cuenta()
        {
            return View();
        }
    }
}