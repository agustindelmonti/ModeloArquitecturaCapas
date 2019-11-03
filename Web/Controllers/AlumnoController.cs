using BusinessLogic;
using BusinessLogic.Authorization;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    [CustomAuthorize(Roles = "Alumno")]
    public class AlumnoController : Controller  {

        InscripcionLogic inscripcionLogic = new InscripcionLogic();
        UsuarioLogic usuarioLogic = new UsuarioLogic();

        // GET: Alumno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EstadoAcademico() {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            var materiasEstado = inscripcionLogic.FindInscripcionesByPersona(persona);

            return View(materiasEstado);

        }
    }
}