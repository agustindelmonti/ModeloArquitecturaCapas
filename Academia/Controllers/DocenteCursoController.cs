using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Academia.DAL;
using Academia.Models;

namespace Academia.Controllers
{
    public class DocenteCursoController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: DocenteCurso
        public ActionResult Index()
        {
            var docenteCursos = db.DocenteCursos.Include(d => d.Curso);
            return View(docenteCursos.ToList());
        }

        // GET: DocenteCurso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = db.DocenteCursos.Find(id);
            if (docenteCurso == null)
            {
                return HttpNotFound();
            }
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Create
        public ActionResult Create()
        {
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID");
            return View();
        }

        // POST: DocenteCurso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocenteCursoID,Cargo,CursoID,DocenteID,State")] DocenteCurso docenteCurso)
        {
            if (ModelState.IsValid)
            {
                db.DocenteCursos.Add(docenteCurso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", docenteCurso.CursoID);
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = db.DocenteCursos.Find(id);
            if (docenteCurso == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", docenteCurso.CursoID);
            return View(docenteCurso);
        }

        // POST: DocenteCurso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocenteCursoID,Cargo,CursoID,DocenteID,State")] DocenteCurso docenteCurso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(docenteCurso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CursoID = new SelectList(db.Cursos, "CursoID", "CursoID", docenteCurso.CursoID);
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = db.DocenteCursos.Find(id);
            if (docenteCurso == null)
            {
                return HttpNotFound();
            }
            return View(docenteCurso);
        }

        // POST: DocenteCurso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocenteCurso docenteCurso = db.DocenteCursos.Find(id);
            db.DocenteCursos.Remove(docenteCurso);
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
