using Prueba.UAM.Inscripciones.Business.Interfaces;
using Prueba.UAM.Inscripciones.Data;
using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;

namespace Prueba.UAM.Inscripciones.Business
{
    public class DatosMaetroBL : IDatosMaetro
    {
        private readonly DatosMaetro datosMaetro = new DatosMaetro();

        public List<Ciudad> ObtenerCiudad(int IdDepartamento)
        {
            return datosMaetro.ObtenerCiudad(IdDepartamento);
        }

        public List<Departamento> ObtenerDepartamentos(int idPais)
        {
            return datosMaetro.ObtenerDepartamentos(idPais);
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            return datosMaetro.ObtenerEstadoCivil();
        }

        public List<Genero> ObtenerGeneros()
        {
            return datosMaetro.ObtenerGeneros();
        }

        public List<GrupoSanguineo> ObtenerGruposSanguineos()
        {
            return datosMaetro.ObtenerGruposSanguineos();
        }

        public List<Modalidad> ObtenerModalidad()
        {
            return datosMaetro.ObtenerModalidad();
        }

        public List<Pais> ObtenerPaises()
        {
            return datosMaetro.ObtenerPaises();
        }

        public List<PeriodoAcademico> ObtenerPeriodosAcademicos()
        {
            return datosMaetro.ObtenerPeriodosAcademicos();
        }

        public List<ProgramaAcademico> ObtenerProgramasAcademicos()
        {
            return datosMaetro.ObtenerProgramasAcademicos();
        }

        public List<Sede> ObtenerSedes()
        {
            return datosMaetro.ObtenerSedes();
        }

        public List<TipoAspirante> ObtenerTipoAspirantes()
        {
            return datosMaetro.ObtenerTipoAspirantes();
        }

        public List<TipoDocumento> ObtenerTiposDocumentos()
        {
            return datosMaetro.ObtenerTiposDocumentos();
        }
    }
}
