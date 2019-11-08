using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Entities;
using BusinessLogic;
using Utils.Exceptions;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
       private UsuarioLogic UsuarioLogic = new UsuarioLogic();

        // GET: /Login
        public ActionResult Login() {
            return View();
        }

        
        // POST: /Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "NombreUsuario,Clave")] Usuario usuario, string returnUrl) {

            if (ModelState.IsValid) {

                try
                {
                    Usuario u = UsuarioLogic.AuthCredentials(usuario);

                    
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                        1,                            // Version
                        u.UsuarioID.ToString(),       // Auth Ticket Name
                        DateTime.Now,                 // Start Date
                        DateTime.Now.AddMinutes(20),  // Expiration
                        false,                        // Persist
                        u.Persona.Role,                // Rol
                        "/");                         // Cookie path
                    
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));
                    Response.Cookies.Add(cookie);


                    if(returnUrl != null) {
                        return Redirect(returnUrl);
                    }
                    else {
                        if (u.Persona.Role == "Alumno") { 
                            return RedirectToAction("index", "Alumno");
                        }
                        if (u.Persona.Role == "Docente") {
                            return RedirectToAction("index", "Docente");
                        }
                        if (u.Persona.Role == "No Docente") {
                            return RedirectToAction("index", "NoDocente");
                        }
                        else {
                            return RedirectToAction("index", "Home");
                        }
                    }

                }
                catch (UserAuthenticationException e)
                {
                    ViewBag.LoginError = e.Message;
                }
            }
            return View();
        }


        // POST: /LogOut
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout() {
            FormsAuthentication.SignOut();

            return RedirectToAction("login", "account");
        }

    }
}
