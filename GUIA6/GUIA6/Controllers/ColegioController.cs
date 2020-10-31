using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GUIA6.Models;
using System.Web.Mvc;

namespace GUIA6.Controllers
{
    public class ColegioController : Controller
    {
        // GET: Colegio
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Notas obNotas)
        {
            string Msj;
            double resultado = (obNotas.NOTA1 + obNotas.NOTA2 + obNotas.NOTA3)/3;
            ViewBag.resultado = resultado;
            if (resultado == 10.00)
            {
                Msj = "Lo Felicito";
                ViewBag.Msj = Msj;
            }
            else if(resultado<10.00 & resultado >= 7.00)
            {
                Msj = "Aprobado ";
                ViewBag.Msj = Msj;
            }
            else if (resultado < 7.00)
            {
                Msj = " necesitas mas Tutorias, recuerda aun puedes seguir adelante";
                ViewBag.Msj = Msj;
            }

            return View(obNotas);


        }
    }
}