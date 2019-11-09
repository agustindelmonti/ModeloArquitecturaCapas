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
    [CustomAuthorize(Roles = "Docente")]
    public class DocenteController : Controller {
        CursoLogic cursoLogic = new CursoLogic();
        UsuarioLogic usuarioLogic = new UsuarioLogic();
        InscripcionLogic inscripcionLogic = new InscripcionLogic();

        IEnumerable<AlumnoInscripcion> alumnosCurso;

        // GET: Docente
        public ActionResult Index() {
            return View();
        }

        // GET: MisCursos
        public ActionResult MisCursos() {

            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);
            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            IEnumerable<Curso> cursosDocente = cursoLogic.FindCursosActualesDocenteByPersonaID(persona.PersonaID);

            return View(cursosDocente);
        }

        public ActionResult AlumnosCurso(string id, bool editar = false)
        {
            int docenteID = Convert.ToInt32(HttpContext.User.Identity.Name);
            int cursoID = Convert.ToInt32(id);

            alumnosCurso = inscripcionLogic.FindInscripcionesByCursoIDAndPersonaID(cursoID, docenteID);
            ViewBag.EditMode = editar;

            return View("AlumnosCurso", alumnosCurso);
        }


        [HttpPost]
        public ActionResult Calificar([Bind(Include = "AlumnoInscripcionID,Nota")] IEnumerable<AlumnoInscripcion> inscripciones) {
            inscripcionLogic.AsignarNotas(inscripciones);

            return RedirectToAction("MisCursos");
        }

    }
}