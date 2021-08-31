using Prueba.UAM.Inscripciones.Data.Interfaces;
using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba.UAM.Inscripciones.Data
{
    public class DatosMaetro : DaoBase, IDatosMaetro
    {
        public List<Ciudad> ObtenerCiudad(int IdDepartamento)
        {
            List<Ciudad> ciudades;
            this.SetUpContext();
            ciudades = (from c in this.Context.CIUDAD
             where c.ID_DEPARTAMENTO == IdDepartamento
             select new Ciudad
             {
                 Id = c.ID,
                 Id_Departamento = c.ID_DEPARTAMENTO,
                 Nombre_Ciudad = c.CIUDAD1
             }).ToList();
            return ciudades;
        }

        public List<Departamento> ObtenerDepartamentos(int idPais)
        {
            List<Departamento> departamentos;
            this.SetUpContext();
            departamentos = (from d in this.Context.DEPARTAMENTO
                        where d.ID_PAIS == 1
                        select new Departamento
                        {
                            Id = d.ID,
                            Id_Pais = d.ID_PAIS,
                            Nombre_Departamento = d.DEPARTAMENTO1
                        }).ToList();
            return departamentos;
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            List<EstadoCivil> estadoCivil;
            this.SetUpContext();
            estadoCivil = (from d in this.Context.ESTADO_CIVIL
                             select new EstadoCivil
                             {
                                 Id = d.ID,
                                 Nombre_Estado_Civil = d.ESTADO_CIVIL1
                             }).ToList();
            return estadoCivil;
        }

        public List<Genero> ObtenerGeneros()
        {
            List<Genero> generos;
            this.SetUpContext();
            generos = (from d in this.Context.GENERO
                           select new Genero
                           {
                               Id = d.ID,
                               Nombre_Genero = d.GENERO1
                           }).ToList();
            return generos;
        }

        public List<GrupoSanguineo> ObtenerGruposSanguineos()
        {
            List<GrupoSanguineo> grupoSanguineos;
            this.SetUpContext();
            grupoSanguineos = (from d in this.Context.GRUPO_SANGUINEO
                       select new GrupoSanguineo
                       {
                           Id = d.ID,
                           Nombre_GrupoSanguineo = d.GRUPO_SANGUINEO1
                       }).ToList();
            return grupoSanguineos;
        }

        public List<Modalidad> ObtenerModalidad()
        {
            List<Modalidad> modalidad;
            this.SetUpContext();
            modalidad = (from d in this.Context.MODALIDAD_ESTUDIO
                               select new Modalidad
                               {
                                   Id = d.ID,
                                   TipoModalidad = d.MODALIDAD
                               }).ToList();
            return modalidad;
        }

        public List<Pais> ObtenerPaises()
        {
            List<Pais> paises;
            this.SetUpContext();
            paises = (from d in this.Context.PAIS
                         select new Pais
                         {
                             Id = d.ID,
                             Nombre_Pais = d.PAIS1
                         }).ToList();
            return paises;
        }

        public List<PeriodoAcademico> ObtenerPeriodosAcademicos()
        {
            List<PeriodoAcademico> periodoAcademicos;
            this.SetUpContext();
            periodoAcademicos = (from d in this.Context.PERIODO_ACADEMICO
                      select new PeriodoAcademico
                      {
                          Id = d.ID,
                          Periodo = d.PERIODO
                      }).ToList();
            return periodoAcademicos;
        }

        public List<ProgramaAcademico> ObtenerProgramasAcademicos()
        {
            List<ProgramaAcademico> programasAcademicos;
            this.SetUpContext();
            programasAcademicos = (from d in this.Context.PROGRAMA_ACADEMICO
                                   select new ProgramaAcademico
                                   {
                                       Id = d.ID,
                                       Programa = d.PROGRAMA_ACADEMICO1
                                   }).ToList();
            return programasAcademicos;
        }

        public List<Sede> ObtenerSedes()
        {
            List<Sede> sedes;
            this.SetUpContext();
            sedes = (from d in this.Context.SEDE
                                   select new Sede
                                   {
                                       Id = d.ID,
                                       Nombre = d.SEDE1
                                   }).ToList();
            return sedes;
        }

        public List<TipoAspirante> ObtenerTipoAspirantes()
        {
            List<TipoAspirante> tipoAspirantes;
            this.SetUpContext();
            tipoAspirantes = (from d in this.Context.TIPO_ASPIRANTE
                     select new TipoAspirante
                     {
                         Id = d.ID,
                         Tipo = d.TIPO
                     }).ToList();
            return tipoAspirantes;
        }

        public List<TipoDocumento> ObtenerTiposDocumentos()
        {
            List<TipoDocumento> tipoDocumentos;
            this.SetUpContext();
            tipoDocumentos = (from d in this.Context.TIPO_ASPIRANTE
                     select new TipoDocumento
                     {
                         Id = d.ID,
                         Nombre_TipoDocumento = d.TIPO
                     }).ToList();
            return tipoDocumentos;
        }
    }
}
