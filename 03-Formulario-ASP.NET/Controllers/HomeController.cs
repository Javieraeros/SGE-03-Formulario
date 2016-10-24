using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03_Formulario_ASP.NET.Models;

namespace _03_Formulario_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ListadoPersona miLista = new ListadoPersona();
            miLista.ListadoDefecto();
            return View(miLista.devuelveListado());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Persona p)
        {
            //Meto la persona en la clase listado de personas
            return View();
        }
    }
}