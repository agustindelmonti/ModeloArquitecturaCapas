using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
    public class HomeController : Controller {
        UsuarioLogic UsuarioLogic = new UsuarioLogic();

        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Perfil()
        {
            int userID = Convert.ToInt32(HttpContext.User.Identity.Name);
            Persona persona = UsuarioLogic.GetPersonaByUserID(userID);
            return View(persona);
        }
    }
}