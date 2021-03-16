using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HelperEditor.Models;

namespace HelperEditor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection coleccion)
        {
            MantenimientoPersona ma = new MantenimientoPersona();
            Persona per = ma.Retornar(int.Parse(coleccion["Codigo"].ToString()));

            if (per != null)
                return View("EditarPersona", per);
            else
                return RedirectToAction("Index");
        }
    }
}