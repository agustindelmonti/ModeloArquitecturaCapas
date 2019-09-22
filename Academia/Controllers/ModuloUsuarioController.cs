using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Academia.DAL;
using Academia.Models;

namespace Academia.Controllers
{
    public class ModuloUsuarioController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: ModuloUsuario
        public ActionResult Index()
        {
            var moduloUsuarios = db.ModuloUsuarios.Include(m => m.Modulo).Include(m => m.Usuario);
            return View(moduloUsuarios.ToList());
        }

        // GET: ModuloUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = db.ModuloUsuarios.Find(id);
            if (moduloUsuario == null)
            {
                return HttpNotFound();
            }
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Create
        public ActionResult Create()
        {
            ViewBag.ModuloID = new SelectList(db.Modulos, "ModuloID", "Descripcion");
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario");
            return View();
        }

        // POST: ModuloUsuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ModuloUsuarioID,PermiteBaja,PermiteModificacion,PermiteAlta,PermiteConsulta,UsuarioID,ModuloID,State")] ModuloUsuario moduloUsuario)
        {
            if (ModelState.IsValid)
            {
                db.ModuloUsuarios.Add(moduloUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ModuloID = new SelectList(db.Modulos, "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = db.ModuloUsuarios.Find(id);
            if (moduloUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.ModuloID = new SelectList(db.Modulos, "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
            return View(moduloUsuario);
        }

        // POST: ModuloUsuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ModuloUsuarioID,PermiteBaja,PermiteModificacion,PermiteAlta,PermiteConsulta,UsuarioID,ModuloID,State")] ModuloUsuario moduloUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moduloUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ModuloID = new SelectList(db.Modulos, "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(db.Usuarios, "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = db.ModuloUsuarios.Find(id);
            if (moduloUsuario == null)
            {
                return HttpNotFound();
            }
            return View(moduloUsuario);
        }

        // POST: ModuloUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModuloUsuario moduloUsuario = db.ModuloUsuarios.Find(id);
            db.ModuloUsuarios.Remove(moduloUsuario);
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
