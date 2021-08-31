using Prueba.UAM.Inscripciones.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.UAM.Inscripciones.Frontend.Controllers
{
    public class GestionController : Controller
    {
        private readonly InscripcionBL inscripcionBL = new InscripcionBL();
        // GET: Gestion
        public ActionResult Index()
        {
            var response = inscripcionBL.ObtenerAspirantesInscritos();
            return View(response);
        }
    }
}