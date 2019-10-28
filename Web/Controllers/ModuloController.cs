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
    public class ModuloController : Controller
    {
        ModuloLogic ModuloLogic = new ModuloLogic();

        // GET: Modulo
        public ActionResult Index()
        {
            IEnumerable<Modulo> modulos = ModuloLogic.GetAll();
            return View(modulos);
        }

        // GET: Modulo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = ModuloLogic.Find(id);
            if (modulo == null)
            {
                return HttpNotFound();
            }
            return View(modulo);
        }

        // GET: Modulo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modulo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Descripcion,Ejecuta,State")] Modulo modulo)
        {
            if (ModelState.IsValid)
            {
                ModuloLogic.Add(modulo);
                return RedirectToAction("Index");
            }

            return View(modulo);
        }

        // GET: Modulo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = ModuloLogic.Find(id);
            if (modulo == null)
            {
                return HttpNotFound();
            }
            return View(modulo);
        }

        // POST: Modulo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ModuloID,Descripcion,Ejecuta,State")] Modulo modulo)
        {
            if (ModelState.IsValid)
            {
                ModuloLogic.Update(modulo);
                return RedirectToAction("Index");
            }
            return View(modulo);
        }

        // GET: Modulo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = ModuloLogic.Find(id);
            if (modulo == null)
            {
                return HttpNotFound();
            }
            return View(modulo);
        }

        // POST: Modulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModuloLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
