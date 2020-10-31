using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GUIA6.Models;
using System.Web.Mvc;

namespace GUIA6.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
          

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(calculo obCalculo)
        {
            
            
            int resultado = obCalculo.numero1 + obCalculo.numero2;
            ViewBag.resultado = resultado;
            int resultado2 = obCalculo.numero1 - obCalculo.numero2;
            ViewBag.resultado2 = resultado2;
            double resultado3 = Convert.ToDouble(obCalculo.numero1 / obCalculo.numero2);
            ViewBag.resultado3 = resultado3;
            int resultado4 = obCalculo.numero1 * obCalculo.numero2;
            ViewBag.resultado4 = resultado4;
            return View(obCalculo);
        }
    }
}