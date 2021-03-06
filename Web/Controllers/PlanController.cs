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
    public class PlanController : Controller
    {
        PlanLogic PlanLogic = new PlanLogic();
        EspecialidadLogic EspecialidadLogic = new EspecialidadLogic();

        // GET: Plan
        public ActionResult Index(string descripcion)
        {
            IEnumerable<Plan> planes = PlanLogic.GetAll();


            if (!String.IsNullOrEmpty(descripcion)) {
                planes = PlanLogic.FilterByDescripcion(planes, descripcion);
            }

            return View(planes);
        }

        // GET: Plan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = PlanLogic.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plan/Create
        public ActionResult Create()
        {
            ViewBag.EspecialidadID = new SelectList(EspecialidadLogic.GetAll(), "EspecialidadID", "Descripcion");
            return View();
        }

        // POST: Plan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descripcion,EspecialidadID")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                PlanLogic.Add(plan);
                return RedirectToAction("Index");
            }

            ViewBag.EspecialidadID = new SelectList(EspecialidadLogic.GetAll(), "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // GET: Plan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = PlanLogic.Find(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            ViewBag.EspecialidadID = new SelectList(EspecialidadLogic.GetAll(), "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // POST: Plan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanID,Descripcion,EspecialidadID")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                PlanLogic.Update(plan);
                return RedirectToAction("Index");
            }
            ViewBag.EspecialidadID = new SelectList(EspecialidadLogic.GetAll(), "EspecialidadID", "Descripcion", plan.EspecialidadID);
            return View(plan);
        }

        // GET: Plan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = PlanLogic.Find(id);
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
            PlanLogic.Delete(id);
            return RedirectToAction("Index");
        }

        //Endpoints API para llamadas AJAX

        //POST 
        [HttpPost]
        public ActionResult GetPlanesByEspecialidad(int especialidadid)
        {
            Especialidad especialidad = EspecialidadLogic.Find(especialidadid);
            List<Plan> planesEspecialidad = PlanLogic.GetAllByEspecialidad(especialidad);
            SelectList planes = new SelectList(planesEspecialidad, "PlanID", "Descripcion", 0);
            return Json(planes);
        }
    }
}
