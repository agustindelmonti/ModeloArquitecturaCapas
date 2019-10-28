using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BusinessLogic;
using Entities;

namespace Web.Controllers
{
    public class DocenteCursoController : Controller
    {
        DocenteCursoLogic DocenteLogic = new DocenteCursoLogic();
        CursoLogic CursoLogic = new CursoLogic();

        // GET: DocenteCurso
        public ActionResult Index()
        {
            IEnumerable<DocenteCurso> docenteCursos = DocenteLogic.GetAll();
            return View(docenteCursos);
        }

        // GET: DocenteCurso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = DocenteLogic.Find(id);
            if (docenteCurso == null)
            {
                return HttpNotFound();
            }
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Create
        public ActionResult Create()
        {
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID");
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
                DocenteLogic.Add(docenteCurso);
                return RedirectToAction("Index");
            }

            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", docenteCurso.CursoID);
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = DocenteLogic.Find(id);
            if (docenteCurso == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", docenteCurso.CursoID);
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
                DocenteLogic.Update(docenteCurso);
                return RedirectToAction("Index");
            }
            ViewBag.CursoID = new SelectList(CursoLogic.GetAll(), "CursoID", "CursoID", docenteCurso.CursoID);
            return View(docenteCurso);
        }

        // GET: DocenteCurso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteCurso docenteCurso = DocenteLogic.Find(id);
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
            DocenteLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
