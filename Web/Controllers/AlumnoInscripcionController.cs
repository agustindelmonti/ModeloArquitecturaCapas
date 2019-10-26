using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Entities;

namespace Web.Controllers
{
    public class AlumnoInscripcionController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: AlumnoInscripcion
        public ActionResult Index()
        {
            var alumnoInscripciones = db.AlumnoInscripciones.Include(a => a.Curso).Include(a => a.Persona);
            return View(alumnoInscripciones.ToList());
        }

        // GET: AlumnoInscripcion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = db.AlumnoInscripciones.Find(id);
            if (alumnoInscripcion == null)
            {
                return HttpNotFound();
            }
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Create
        public ActionResult Create()
        {
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID");
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "Nombre");
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
                db.AlumnoInscripciones.Add(alumnoInscripcion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = db.AlumnoInscripciones.Find(id);
            if (alumnoInscripcion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
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
                db.Entry(alumnoInscripcion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", alumnoInscripcion.CursoID);
            ViewBag.PersonaID = new SelectList(db.Personas, "PersonaID", "Nombre", alumnoInscripcion.PersonaID);
            return View(alumnoInscripcion);
        }

        // GET: AlumnoInscripcion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AlumnoInscripcion alumnoInscripcion = db.AlumnoInscripciones.Find(id);
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
            AlumnoInscripcion alumnoInscripcion = db.AlumnoInscripciones.Find(id);
            db.AlumnoInscripciones.Remove(alumnoInscripcion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
