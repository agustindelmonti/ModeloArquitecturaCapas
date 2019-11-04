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
    [CustomAuthorize(Roles = "No Docente")]
    public class MateriaController : Controller
    {
        MateriaLogic MateriaLogic = new MateriaLogic(); 
        PlanLogic PlanLogic = new PlanLogic();

        // GET: Materia
        public ActionResult Index(string descripcion)
        {
            IEnumerable<Materia> materias = MateriaLogic.GetAll();

            if (!String.IsNullOrEmpty(descripcion)) {
                materias = MateriaLogic.FilterByDescripcion(materias, descripcion);
            }

            return View(materias);
        }

        // GET: Materia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = MateriaLogic.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // GET: Materia/Create
        public ActionResult Create()
        {
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion");
            return View();
        }

        // POST: Materia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descripcion,HsSemanales,HsTotales,PlanID,State")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                MateriaLogic.Add(materia);
                return RedirectToAction("Index");
            }

            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", materia.PlanID);
            return View(materia);
        }

        // GET: Materia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = MateriaLogic.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", materia.PlanID);
            return View(materia);
        }

        // POST: Materia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MateriaID,Descripcion,HsSemanales,HsTotales,PlanID,State")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                MateriaLogic.Update(materia);
                return RedirectToAction("Index");
            }
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", materia.PlanID);
            return View(materia);
        }

        // GET: Materia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = MateriaLogic.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // POST: Materia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MateriaLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
