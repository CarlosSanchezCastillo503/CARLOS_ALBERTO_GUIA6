using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GUIA6.Models;
using System.Web.Mvc;

namespace GUIA6.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        // GET: Ejercicio1
        public ActionResult Index()
        {           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Medidas obMedidas)
        {

            double resultado1 = obMedidas.Variable1 + obMedidas.Variable2;///De celsius a Kelvin
            ViewBag.resultado1 = resultado1;
            double resultado1_1= obMedidas.Variable1 - obMedidas.Variable2;/// de Kelvin a Celsius
            ViewBag.resultado1_1 = resultado1_1;
            double resultado2 = obMedidas.Variable1 * 2.205; ///De Kilogramos a Libras
            ViewBag.resultado2 = resultado2;
            double resultado2_2 = obMedidas.Variable1 / 2.205;/// De Libras a Kilogramos
            ViewBag.resultado2_2 = resultado2_2;
            double resultado3 = obMedidas.Variable1 * 39.37;/// De metros a Pulgadas
            ViewBag.resultado3 = resultado3;
            return View(obMedidas);
            

        }
    }
}