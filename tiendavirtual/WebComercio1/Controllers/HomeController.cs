using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComercio1.Controllers
{
    public class HomeController : Controller
    {


        private Models.WebComercioEntities bd = new Models.WebComercioEntities();

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LLogin()
        {
            return View();
        }
        public ActionResult Productos(string id = "")
        {
            //logica de acceso a base de datos
            var productos = bd.Producto
                .Where(x => x.Denominacion.Contains(id))
                .Take(20)
                .ToList();
            // lista de productos
           // ViewBag.clave = id;
            return View(productos);

            // ViewBag.ListaCategoria = bd.Categoria.Take(20).ToList();
        }
     
        public ActionResult Buscar()
        {
            return View();
        }
    }
}