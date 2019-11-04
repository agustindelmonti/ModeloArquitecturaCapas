using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessLogic.Authorization;
using Entities;

namespace Web.Controllers
{
    [CustomAuthorize(Roles= "No Docente")]
    public class AlumnoInscripcionController : Controller
    {
        InscripcionLogic InscripcionLogic = new InscripcionLogic();
        CursoLogic CursoLogic = new CursoLogic();
        PersonaLogic PersonaLogic = new PersonaLogic();

        // GET: AlumnoInscripcion
        [Authorize]
        public ActionResult Index()
        {
            IEnumerable<AlumnoInscripcion> alumnoInscripciones = InscripcionLogic.GetInscripcionesWithCursoAndPersona();
            return View(alumnoInscripciones);
        }

        // GET: AlumnoInscripcion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = InscripcionLogic.Find(id);
            if (alumnoInscripcion == null)
            {
                return HttpNotFound();
            }
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Create
        public ActionResult Create()
        {
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID");
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre");
            return View();
        }

        // POST: AlumnoInscripcion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Condicion,Nota,PersonaID,CursoID,State")] AlumnoInscripcion alumnoInscripcion)
        {
            if (ModelState.IsValid)
            {
                InscripcionLogic.Add(alumnoInscripcion);
                return RedirectToAction("Index");
            }

            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = InscripcionLogic.Find(id);
            if (alumnoInscripcion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
            return View(alumnoInscripcion);
        }

        // POST: AlumnoInscripcion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlumnoInscripcionID,Condicion,Nota,PersonaID,CursoID,State")] AlumnoInscripcion alumnoInscripcion)
        {
            if (ModelState.IsValid)
            {
                InscripcionLogic.Update(alumnoInscripcion);
                return RedirectToAction("Index");
            }
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = InscripcionLogic.Find(id);
            if (alumnoInscripcion == null)
            {
                return HttpNotFound();
            }
            return View(alumnoInscripcion);
        }

        // POST: AlumnoInscripcion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InscripcionLogic.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
