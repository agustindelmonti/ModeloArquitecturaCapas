﻿using System;
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
    public class CursoController : Controller
    {
        CursoLogic CursoLogic = new CursoLogic();
        MateriaLogic MateriaLogic = new MateriaLogic();
        ComisionLogic ComisionLogic = new ComisionLogic();

        // GET: Curso
        public ActionResult Index(string año, string materia)
        {
            IEnumerable<Curso> cursos = CursoLogic.GetAll();

            if (!String.IsNullOrEmpty(año)) {
                cursos = CursoLogic.FilterByAnioCalendario(cursos, año);
            }
            if (!String.IsNullOrEmpty(materia)) {
                cursos = CursoLogic.FilterByNombreMateria(cursos, materia);
            }

            return View(cursos);
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
            ViewBag.ComisionID = new SelectList(ComisionLogic.GetAll(), "ComisionID", "Descripcion");
            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnioCalendario,Cupo,MateriaID,ComisionID")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                CursoLogic.Add(curso);
                return RedirectToAction("Index");
            }

            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion", curso.MateriaID);
            ViewBag.ComisionID = new SelectList(ComisionLogic.GetAll(), "ComisionID", "Descripcion", curso.ComisionID);
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
            ViewBag.ComisionID = new SelectList(ComisionLogic.GetAll(), "ComisionID", "Descripcion", curso.ComisionID);
            return View(curso);
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CursoID,AnioCalendario,Cupo,MateriaID, ComisionID")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                CursoLogic.Update(curso);
                return RedirectToAction("Index");
            }
            ViewBag.MateriaID = new SelectList(MateriaLogic.GetAll(), "MateriaID", "Descripcion", curso.MateriaID);
            ViewBag.ComisionID = new SelectList(ComisionLogic.GetAll(), "ComisionID", "Descripcion", curso.ComisionID);
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
