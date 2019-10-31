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
        public AccountManager accountManager = new AccountManager();

        // GET: /Login
        public ActionResult Login() {
            return View();
        }

        
        // POST: /Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "NombreUsuario,Clave")] Usuario usuario) {
            if (ModelState.IsValid) {
                AccountManager acountManager = new AccountManager();
                bool found = acountManager.ValidateUser(usuario);


                if (found) {
                    FormsAuthentication.RedirectFromLoginPage(usuario.NombreUsuario, true);
                }
            }
            ViewBag.LoginError = "Usuario y/o contraseña incorrecta";
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
