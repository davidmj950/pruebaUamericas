using Prueba.UAM.Inscripciones.Data.Interfaces;
using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba.UAM.Inscripciones.Data
{
    public class Inscripcion : DaoBase, IInscripcion
    {
        public IncripcionesAspirante GuardarAspirante(IncripcionesAspirante aspirante)
        {
            this.SetUpContext();
            var aspiranteDao = new ASPIRANTE
            {
                PRIMER_NOMBRE = aspirante.Aspirante.PrimerNombre,
                PRIMER_APELLIDO = aspirante.Aspirante.PrimerApellido,
                SEGUNDO_APELLIDO = aspirante.Aspirante.SegundoApellido,
                SEGUNDO_NOMBRE = aspirante.Aspirante.SegundoApellido,
                IDENTIFICACION = aspirante.Aspirante.Identificacion,
                ID_CIUDAD_EXPEDICION = aspirante.Aspirante.IdCiudadExpedicion,
                ID_CIUDAD_NACIMIENTO = aspirante.Aspirante.IdCiudadNacimiento,
                ID_ESTADO_CIVIL = aspirante.Aspirante.IdEstadoCivil,
                ID_GRUPO_SANGUINEO = aspirante.Aspirante.IdGrupoSanguineo,
                ID_TIPO_DOCUMENTO = aspirante.Aspirante.IdTipoDocumento,
                ID_GENERO = aspirante.Aspirante.IdGenero

            };
            aspirante.Aspirante.Id = this.Context.ASPIRANTE.Add(aspiranteDao).ID;

            var inscripcionAspiranteDao = new INSCRIPCION_ASPIRANTE
            {
                ID_ASPIRANTE = aspirante.Id,
                ID_MODALIDAD = aspirante.IdModalidad,
                ID_PERIODO_ACADEMICO = aspirante.IdPeriodoAcademico,
                ID_PROGRAMA_ACADEMICO = aspirante.IdProgramaAcademico,
                ID_SEDE = aspirante.IdSede,
                ID_TIPO_ASPIRANTE = aspirante.IdTipoAspirante
            };
            aspirante.Id = this.Context.INSCRIPCION_ASPIRANTE.Add(inscripcionAspiranteDao).ID;
            return aspirante;
        }

        public List<AspirantesInscritos> ObtenerAspirantesInscritos()
        {
            this.SetUpContext();
            List<AspirantesInscritos> aspirantesInscritos = new List<AspirantesInscritos>();
            var response = this.Context.ASPIRANTES_INSCRITOS().ToList();
            foreach (var item in response)
            {
                aspirantesInscritos.Add(new AspirantesInscritos
                {
                    Apellidos = item.APELLIDOS,
                    Estado = item.ESTADO,
                    EstadoCIvil = item.ESTADO_CIVIL1,
                    Genero = item.GENERO,
                    Identificacion = item.IDENTIFICACION,
                    Nombres = item.NOMBRES,
                    Periodo = item.PERIODO,
                    ProgramaAcademico = item.PERIODO,
                    Sede = item.SEDE,
                    TipoDocumento = item.ESTADO_CIVIL
                });
            }
            return aspirantesInscritos;
        }
    }
}
