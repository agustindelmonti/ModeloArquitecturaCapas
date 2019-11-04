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
    public class UsuarioController : Controller
    {
        UsuarioLogic UsuarioLogic = new UsuarioLogic();
        PersonaLogic PersonaLogic = new PersonaLogic();

        // GET: Usuario
        public ActionResult Index(string nombreUsuario)
        {
            IEnumerable<Usuario> usuarios = UsuarioLogic.GetAll();

            if (!String.IsNullOrEmpty(nombreUsuario)) {
                usuarios = UsuarioLogic.FilterByNombreUsuario(usuarios, nombreUsuario);
            }

            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = UsuarioLogic.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NombreUsuario,Clave,Habilitado,CambioClave,PersonaID,State")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                UsuarioLogic.Add(usuario);
                return RedirectToAction("Index");
            }

            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", usuario.PersonaID);
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = UsuarioLogic.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", usuario.PersonaID);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,NombreUsuario,Clave,Habilitado,CambioClave,PersonaID,State")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                UsuarioLogic.Update(usuario);
                return RedirectToAction("Index");
            }
            ViewBag.PersonaID = new SelectList(PersonaLogic.GetAll(), "PersonaID", "Nombre", usuario.PersonaID);
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = UsuarioLogic.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
