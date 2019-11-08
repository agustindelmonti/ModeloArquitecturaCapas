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

        [HttpGet]
        public ActionResult Inscripcion() {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);


            IEnumerable<Curso> cursosHabilitadosInscripcion = cursoLogic.FindCursosHabilitadosByPersonaID(persona.PersonaID);

            if (cursosHabilitadosInscripcion.Count() == 0) {
                ViewBag.ErrorMessage = "No hay cursos en los que se pueda inscribir.";
            }

            return View(cursosHabilitadosInscripcion);
        }
        

        [HttpPost]
        public ActionResult Confirmar([Bind(Include = "CursoID")] Curso curso) {

            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            inscripcionLogic.InscribirAlumno(persona.PersonaID, curso.CursoID);

            return RedirectToAction("Index");
        }
        

        
    }
}