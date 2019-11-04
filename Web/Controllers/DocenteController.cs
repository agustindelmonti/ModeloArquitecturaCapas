﻿using BusinessLogic;
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

        public ActionResult MisCursos(string id, bool editar = false) {

            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);

            ViewBag.EditMode = editar;

            Persona persona = usuarioLogic.GetPersonaByUserID(userID);

            if (String.IsNullOrEmpty(id)) {
                IEnumerable<Curso> cursosDocente = cursoLogic.FindCursosActualesDocenteByPersonaID(persona.PersonaID);

                return View(cursosDocente);
            }
            else {
                int cursoID = Convert.ToInt32(id);
                int docenteID = persona.PersonaID;
                alumnosCurso = inscripcionLogic.FindInscripcionesByCursoIDAndPersonaID(cursoID, docenteID);

                return View("AlumnosCurso", alumnosCurso);
            }
        }


        [HttpPost]
        public ActionResult Calificar([Bind(Include = "AlumnoInscripcionID,Nota")] IEnumerable<AlumnoInscripcion> inscripciones) {
            inscripcionLogic.AsignarNotas(inscripciones);

            return RedirectToAction("MisCursos");
        }

    }
}