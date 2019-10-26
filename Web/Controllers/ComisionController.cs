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
    public class ComisionController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: Comision
        public ActionResult Index()
        {
            var comisiones = db.Comisiones.Include(c => c.Plan);
            return View(comisiones.ToList());
        }

        // GET: Comision/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = db.Comisiones.Find(id);
            if (comision == null)
            {
                return HttpNotFound();
            }
            return View(comision);
        }

        // GET: Comision/Create
        public ActionResult Create()
        {
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion");
            return View();
        }

        // POST: Comision/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descripcion,AnioEspecialidad,PlanID,State")] Comision comision)
        {
            if (ModelState.IsValid)
            {
                db.Comisiones.Add(comision);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", comision.PlanID);
            return View(comision);
        }

        // GET: Comision/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = db.Comisiones.Find(id);
            if (comision == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", comision.PlanID);
            return View(comision);
        }

        // POST: Comision/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComisionID,Descripcion,AnioEspecialidad,PlanID,State")] Comision comision)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comision).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", comision.PlanID);
            return View(comision);
        }

        // GET: Comision/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = db.Comisiones.Find(id);
            if (comision == null)
            {
                return HttpNotFound();
            }
            return View(comision);
        }

        // POST: Comision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comision comision = db.Comisiones.Find(id);
            db.Comisiones.Remove(comision);
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
