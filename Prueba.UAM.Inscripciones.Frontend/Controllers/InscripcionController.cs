using Prueba.UAM.Inscripciones.Business;
using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.UAM.Inscripciones.Frontend.Controllers
{
    public class InscripcionController : Controller
    {
        // GET: Inscripcion
        private readonly DatosMaetroBL datosMaetro = new DatosMaetroBL();
        private readonly InscripcionBL inscripcionBL = new InscripcionBL();

        [HttpGet]
        public ActionResult Index()
        {
            this.CargarDatosGenerales();
            return View();
        }

        private void CargarDatosGenerales()
        {
            ViewBag.EstadoCivil = datosMaetro.ObtenerEstadoCivil();
            ViewBag.Generos = datosMaetro.ObtenerGeneros();
            ViewBag.GrupoSanguineos = datosMaetro.ObtenerGruposSanguineos();
            ViewBag.Modalidad = datosMaetro.ObtenerModalidad();
            ViewBag.Paises = datosMaetro.ObtenerPaises();
            ViewBag.PeriodosAcademicos = datosMaetro.ObtenerPeriodosAcademicos();
            ViewBag.ProgramasAcademicos = datosMaetro.ObtenerProgramasAcademicos();
            ViewBag.Sedes = datosMaetro.ObtenerSedes();
            ViewBag.TipoAspirantes = datosMaetro.ObtenerTipoAspirantes();
            ViewBag.TipoDocumentos = datosMaetro.ObtenerTiposDocumentos();
            ViewBag.Departamentos = datosMaetro.ObtenerDepartamentos(1);
            ViewBag.Ciudades = datosMaetro.ObtenerCiudad(1);
        }

        [HttpPost]
        public ActionResult Create(IncripcionesAspirante aspirante)
        {
            if (!ModelState.IsValid)
            {
                //ViewBag.StartUpScript = distributorBLL.Save(model);
            }
            var response = this.inscripcionBL.GuardarAspirante(aspirante);
            if (response.Id > 0)
            {
            }
            return View();
        }

        public ActionResult Departamentos(int? idPais)
        {
            this.CargarDatosGenerales();
            ViewBag.Departamentos = datosMaetro.ObtenerDepartamentos(1);
            return View("Index");
        }

        public ActionResult Ciudades(int? idDepartamento)
        {
            this.CargarDatosGenerales();
            ViewBag.Ciudades = datosMaetro.ObtenerDepartamentos(1);
            return View("Index");
        }
    }
}