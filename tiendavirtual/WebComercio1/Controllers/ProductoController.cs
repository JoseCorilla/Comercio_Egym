using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebComercio1.Controllers
{

    public class ProductoController : Controller
    {
        private Models.WebComercioEntities bd  = new Models.WebComercioEntities();

        // GET: Producto
        public ActionResult Index()
        {
            ViewBag.ListaCategoria = bd.Categoria.Take(20).ToList();
          // var Categorias = 
            return View();
        }
    }
}