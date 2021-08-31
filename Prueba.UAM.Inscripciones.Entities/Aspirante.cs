using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.UAM.Inscripciones.Entities
{
    public class Aspirante
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public int IdGenero { get; set; }
        public int IdCiudadNacimiento { get; set; }
        public int IdGrupoSanguineo { get; set; }
        public string Identificacion { get; set; }
        public int IdCiudadExpedicion { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdTipoDocumento { get; set; }
        public DateTime FechaExpedicion { get; set; }


        public Genero Genero { get; set; }
        public Ciudad CiudadNacimiento { get; set; }
        public GrupoSanguineo GrupoSanguineo { get; set; }
        public Ciudad CiudadExpedicion { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

    }
}
