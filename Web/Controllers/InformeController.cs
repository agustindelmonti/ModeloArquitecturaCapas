using BusinessLogic;
using BusinessLogic.Authorization;
using Entities;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    [CustomAuthorize(Roles = "Docente")]
    public class InformeController : Controller
    {
        // GET: Informe
        public ActionResult ReporteCurso(string id)
        {
            int cursoID = Convert.ToInt32(id);
            CursoLogic cursoLogic = new CursoLogic();
            Curso curso = cursoLogic.FindByIdWithInscripciones(cursoID);

            return View(curso);
        }

        public ActionResult Print(string curso)
        {
            Dictionary<string, string> cookieCollection = new Dictionary<string, string>();
            foreach (var key in Request.Cookies.AllKeys)
            {
                cookieCollection.Add(key, Request.Cookies.Get(key).Value);
            }
            return new ActionAsPdf("ReporteCurso", new { id = curso })
            {
                FileName = $"ListadoCurso{curso}.pdf",
                Cookies = cookieCollection
            };
        }

    }
}
