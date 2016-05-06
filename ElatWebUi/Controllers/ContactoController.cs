using ElatWebUi.Helpers;
using ElatWebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElatWebUi.Controllers
{
    public class ContactoController : Controller
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult EnviarComentario(Contacto contacto)
        {
            EnviarEmail ev = new EnviarEmail();
            var res = ev.EnviarComentarios(contacto);
            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}
