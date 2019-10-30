﻿using System;
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
    public class ComisionController : Controller
    {
        ComisionLogic ComisionLogic = new ComisionLogic();
        PlanLogic PlanLogic = new PlanLogic();

        // GET: Comision
        public ActionResult Index()
        {
            IEnumerable<Comision> comisiones = ComisionLogic.GetAll();
            return View(comisiones);
        }

        // GET: Comision/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = ComisionLogic.Find(id);
            if (comision == null)
            {
                return HttpNotFound();
            }
            return View(comision);
        }

        // GET: Comision/Create
        public ActionResult Create()
        {
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion");
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
                ComisionLogic.Add(comision);
                return RedirectToAction("Index");
            }

            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", comision.PlanID);
            return View(comision);
        }

        // GET: Comision/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = ComisionLogic.Find(id);
            if (comision == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", comision.PlanID);
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
                ComisionLogic.Update(comision);
                return RedirectToAction("Index");
            }
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", comision.PlanID);
            return View(comision);
        }

        // GET: Comision/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comision comision = ComisionLogic.Find(id);
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
            ComisionLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
