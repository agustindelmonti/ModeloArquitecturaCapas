using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Entities;
using Web.Models;

namespace Web.Controllers
{
    public class PersonaController : Controller
    {
        private AcademiaContext db = new AcademiaContext();

        // GET: Persona
        public ActionResult Index()
        {
            var personas = db.Personas.Include(p => p.Plan);
            return View(personas.ToList());
        }

        // GET: Persona/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion");
            return View();
        }

        // POST: Persona/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonaID,Nombre,Apellido,Direccion,Email,Telefono,FechaNacimiento,Legajo,TipoPersona,PlanID,State")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", persona.PlanID);
            return View(persona);
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", persona.PlanID);
            return View(persona);
        }

        // POST: Persona/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonaID,Nombre,Apellido,Direccion,Email,Telefono,FechaNacimiento,Legajo,TipoPersona,PlanID,State")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlanID = new SelectList(db.Planes, "PlanID", "Descripcion", persona.PlanID);
            return View(persona);
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
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
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
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

        // GET: Persona/Horario/5
        public ActionResult Horario(int? id)
        {
            //Persona persona = db.Personas.Find(id);

            
            HashSet<BloqueCursado> Bloques = new HashSet<BloqueCursado>()
            {
                new BloqueCursado("7:15", "8:00", DayOfWeek.Friday),
                new BloqueCursado("7:15", "8:00", DayOfWeek.Friday)
            };

            return View(Bloques);
        }

    }
}
