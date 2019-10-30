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
    public class ModuloUsuarioController : Controller
    {
        ModuloUsuarioLogic ModuloUsuarioLogic = new ModuloUsuarioLogic();
        ModuloLogic ModuloLogic = new ModuloLogic();
        UsuarioLogic UsuarioLogic = new UsuarioLogic();

        // GET: ModuloUsuario
        public ActionResult Index()
        {
            var moduloUsuarios = ModuloUsuarioLogic.GetAll();
            return View(moduloUsuarios);
        }

        // GET: ModuloUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = ModuloUsuarioLogic.Find(id);
            if (moduloUsuario == null)
            {
                return HttpNotFound();
            }
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Create
        public ActionResult Create()
        {
            ViewBag.ModuloID = new SelectList(ModuloLogic.GetAll(), "ModuloID", "Descripcion");
            ViewBag.UsuarioID = new SelectList(UsuarioLogic.GetAll(), "UsuarioID", "NombreUsuario");
            return View();
        }

        // POST: ModuloUsuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PermiteBaja,PermiteModificacion,PermiteAlta,PermiteConsulta,UsuarioID,ModuloID,State")] ModuloUsuario moduloUsuario)
        {
            if (ModelState.IsValid)
            {
                ModuloUsuarioLogic.Add(moduloUsuario);
                return RedirectToAction("Index");
            }

            ViewBag.ModuloID = new SelectList(ModuloLogic.GetAll(), "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(UsuarioLogic.GetAll(), "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = ModuloUsuarioLogic.Find(id);
            if (moduloUsuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.ModuloID = new SelectList(ModuloLogic.GetAll(), "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(UsuarioLogic.GetAll(), "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
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
                ModuloUsuarioLogic.Update(moduloUsuario);
                return RedirectToAction("Index");
            }
            ViewBag.ModuloID = new SelectList(ModuloLogic.GetAll(), "ModuloID", "Descripcion", moduloUsuario.ModuloID);
            ViewBag.UsuarioID = new SelectList(UsuarioLogic.GetAll(), "UsuarioID", "NombreUsuario", moduloUsuario.UsuarioID);
            return View(moduloUsuario);
        }

        // GET: ModuloUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModuloUsuario moduloUsuario = ModuloUsuarioLogic.Find(id);
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
            ModuloUsuarioLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
