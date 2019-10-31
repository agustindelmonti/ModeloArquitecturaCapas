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
        public ActionResult Login([Bind(Include = "NombreUsuario,Clave")] Usuario usuario) {

            if (ModelState.IsValid) {

                try
                {
                    Usuario u = UsuarioLogic.AuthCredentials(usuario);
                    FormsAuthentication.RedirectFromLoginPage(u.NombreUsuario, true);
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
