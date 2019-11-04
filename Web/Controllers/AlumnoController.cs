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
        CursoLogic cursoLogic = new CursoLogic();

        // GET: Alumno
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EstadoAcademico() {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            IEnumerable<AlumnoInscripcion> inscripcionesEstado = inscripcionLogic.FindInscripcionesByPersonaID(persona.PersonaID);

            return View(inscripcionesEstado);

        }

        
        public ActionResult MisCursos() {

            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            IEnumerable<Curso> cursosActuales = cursoLogic.FindCursosActualesAlumnoByPersonaID(persona.PersonaID);

            return View(cursosActuales);

        }

        public ActionResult Inscripcion() {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);


            IEnumerable<Curso> cursosHabilitadosInscripcion = cursoLogic.FindCursosHabilitadosByPersonaID(persona.PersonaID);

            return View(cursosHabilitadosInscripcion);
        }
        /*
        [HttpPost]
        public ActionResult Inscripcion([Bind) {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

        }
        */

        
    }
}