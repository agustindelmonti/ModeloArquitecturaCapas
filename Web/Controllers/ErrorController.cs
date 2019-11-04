using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace Web.Controllers
{

    public class ErrorController : Controller
    {

        public ActionResult Oops(int id)
        {
            Response.StatusCode = id;
            return View();
        }
    }
}
