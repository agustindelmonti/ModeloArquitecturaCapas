using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using Entities;

namespace Web.Controllers
{
    public class CursoController : Controller
    {
        CursoLogic CursoLogic = new CursoLogic();
        MateriaLogic MateriaLogic = new MateriaLogic();

        // GET: Curso
        public ActionResult Index()
        {
            return View(CursoLogic.GetAll());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Curso curso = CursoLogic.Find(id);

            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion");
            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnioCalendario,Cupo,MateriaID,State")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                CursoLogic.Add(curso);
                return RedirectToAction("Index");
            }

            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion", curso.MateriaID);
            return View(curso);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = CursoLogic.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion", curso.MateriaID);
            return View(curso);
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CursoID,AnioCalendario,Cupo,MateriaID,State")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                CursoLogic.Update(curso);
                return RedirectToAction("Index");
            }
            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion", curso.MateriaID);
            return View(curso);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = CursoLogic.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CursoLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
