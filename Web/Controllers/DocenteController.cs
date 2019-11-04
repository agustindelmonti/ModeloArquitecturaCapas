using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MisCursos() {


            return View();
        }


        public ActionResult MisCursos(int id) {
            return View("AlumnosCurso");
        }
    }
}