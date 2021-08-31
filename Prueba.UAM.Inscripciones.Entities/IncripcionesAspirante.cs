using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.UAM.Inscripciones.Entities
{
    public class IncripcionesAspirante
    {
        public int Id { get; set; }
        public int IdAspirante { get; set; }
        public int IdTipoAspirante { get; set; }
        public int IdModalidad { get; set; }
        public int IdProgramaAcademico { get; set; }
        public int IdSede { get; set; }
        public int IdPeriodoAcademico { get; set; }


        public Aspirante Aspirante { get; set; }
        public TipoAspirante TipoAspirante { get; set; }
        public Modalidad Modalidad { get; set; }
        public ProgramaAcademico ProgramaAcademico { get; set; }
        public Sede Sede { get; set; }
        public PeriodoAcademico PeriodoAcademico { get; set; }
    }
}
