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
    [CustomAuthorize(Roles="Alumno")]
    public class PersonaController : Controller
    {
        PersonaLogic PersonaLogic = new PersonaLogic();
        PlanLogic PlanLogic = new PlanLogic();

        // GET: Persona
        public ActionResult Index(string legajo, string rol)
        {
            IEnumerable<Persona> personas = PersonaLogic.GetAll();

            if (!String.IsNullOrEmpty(legajo)) {
                personas = PersonaLogic.FilterByLegajo(personas, legajo);
            }

            if (!String.IsNullOrEmpty(rol)) {
                personas = PersonaLogic.FilterByRole(personas, rol);
            }

            ViewBag.Rol = new SelectList(Persona.Roles);
            return View(personas);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = PersonaLogic.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion");

            var personas = PersonaLogic.GetAll();

            ViewBag.Rol = new SelectList(   
                                        Persona.Roles.Select(r => new SelectListItem { Text = r, Value = r})
                                        , "Text"
                                        , "Value" );
            return View();
        }

        // POST: Persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre,Apellido,Direccion,Email,Telefono,FechaNacimiento,Legajo,Rol,PlanID,State")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                PersonaLogic.Add(persona);
                return RedirectToAction("Index");
            }

            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", persona.PlanID);

            ViewBag.Rol = new SelectList(
                                        Persona.Roles.Select(r => new SelectListItem { Text = r, Value = r })
                                        , "Text"
                                        , "Value");

            return View(persona);
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = PersonaLogic.Find(id);

            if (persona == null)
            {
                return HttpNotFound();
            }
            
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", persona.PlanID);
            ViewBag.Rol = new SelectList(
                                        Persona.Roles.Select(r => new SelectListItem { Text = r, Value = r })
                                        , "Text"
                                        , "Value");

            return View(persona);
        }

        // POST: Persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonaID,Nombre,Apellido,Direccion,Email,Telefono,FechaNacimiento,Legajo,Rol,PlanID,State")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                PersonaLogic.Update(persona);
                return RedirectToAction("Index");
            }
            ViewBag.PlanID = new SelectList(PlanLogic.GetAll(), "PlanID", "Descripcion", persona.PlanID);

            ViewBag.Rol = new SelectList(
                                        Persona.Roles.Select(r => new SelectListItem { Text = r, Value = r })
                                        , "Text"
                                        , "Value");

            return View(persona);
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = PersonaLogic.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonaLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
