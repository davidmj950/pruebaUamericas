using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.UAM.Inscripciones.Business.Interfafaces
{
    public interface IInscripcionBL
    {
        IncripcionesAspirante GuardarAspirante(IncripcionesAspirante aspirante);
        List<AspirantesInscritos> ObtenerAspirantesInscritos();
    }
}
