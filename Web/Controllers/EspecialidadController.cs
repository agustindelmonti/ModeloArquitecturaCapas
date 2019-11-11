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
    public class EspecialidadController : Controller
    {
        EspecialidadLogic EspecialidadLogic = new EspecialidadLogic();

        // GET: Especialidad
        public ActionResult Index(string descripcion)
        {
            IEnumerable<Especialidad>  especialidades = EspecialidadLogic.GetAll();

            if (!String.IsNullOrEmpty(descripcion)) {
                especialidades = EspecialidadLogic.FilterByDescripcion(especialidades, descripcion);
            }

            return View(especialidades);
        }

        // GET: Especialidad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidad especialidad = EspecialidadLogic.Find(id);
            if (especialidad == null)
            {
                return HttpNotFound();
            }
            return View(especialidad);
        }

        // GET: Especialidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especialidad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descripcion")] Especialidad especialidad)
        {
            if (ModelState.IsValid)
            {
                EspecialidadLogic.Add(especialidad);
                return RedirectToAction("Index");
            }

            return View(especialidad);
        }

        // GET: Especialidad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidad especialidad = EspecialidadLogic.Find(id);
            if (especialidad == null)
            {
                return HttpNotFound();
            }
            return View(especialidad);
        }

        // POST: Especialidad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EspecialidadID,Descripcion")] Especialidad especialidad)
        {
            if (ModelState.IsValid)
            {
                EspecialidadLogic.Update(especialidad);
                return RedirectToAction("Index");
            }
            return View(especialidad);
        }

        // GET: Especialidad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidad especialidad = EspecialidadLogic.Find(id);
            if (especialidad == null)
            {
                return HttpNotFound();
            }
            return View(especialidad);
        }

        // POST: Especialidad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EspecialidadLogic.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
