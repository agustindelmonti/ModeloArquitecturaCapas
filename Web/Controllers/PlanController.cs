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
    public class PlanController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: Plan
        public ActionResult Index()
        {
            var planes = db.Planes.Include(p => p.Especialidad);
            return View(planes.ToList());
        }

        // GET: Plan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Planes.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plan/Create
        public ActionResult Create()
        {
            ViewBag.EspecialidadID = new SelectList(db.Especialidades, "EspecialidadID", "Descripcion");
            return View();
        }

        // POST: Plan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanID,Descripcion,EspecialidadID,State")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                db.Planes.Add(plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EspecialidadID = new SelectList(db.Especialidades, "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // GET: Plan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Planes.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            ViewBag.EspecialidadID = new SelectList(db.Especialidades, "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // POST: Plan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanID,Descripcion,EspecialidadID,State")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EspecialidadID = new SelectList(db.Especialidades, "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // GET: Plan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = db.Planes.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plan plan = db.Planes.Find(id);
            db.Planes.Remove(plan);
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
