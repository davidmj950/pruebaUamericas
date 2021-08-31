using Prueba.UAM.Inscripciones.Entities;
using System.Collections.Generic;

namespace Prueba.UAM.Inscripciones.Data.Interfaces
{
    public interface IDatosMaetro
    {
        List<Genero> ObtenerGeneros();
        List<EstadoCivil> ObtenerEstadoCivil();
        List<TipoDocumento> ObtenerTiposDocumentos();
        List<Pais> ObtenerPaises();
        List<Departamento> ObtenerDepartamentos(int idPais);
        List<Ciudad> ObtenerCiudad(int IdDepartamento);
        List<GrupoSanguineo> ObtenerGruposSanguineos();
        List<TipoAspirante> ObtenerTipoAspirantes();
        List<Modalidad> ObtenerModalidad();
        List<Sede> ObtenerSedes();
        List<ProgramaAcademico> ObtenerProgramasAcademicos();
        List<PeriodoAcademico> ObtenerPeriodosAcademicos();
    }
}
