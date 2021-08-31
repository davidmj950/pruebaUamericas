using Prueba.UAM.Inscripciones.Business.Interfafaces;
using Prueba.UAM.Inscripciones.Data;
using Prueba.UAM.Inscripciones.Data.Interfaces;
using Prueba.UAM.Inscripciones.Entities;
using System;
using System.Collections.Generic;

namespace Prueba.UAM.Inscripciones.Business
{
    public class InscripcionBL : IInscripcionBL
    {
        private IInscripcion inscripcionDao;

        public InscripcionBL()
        {
            inscripcionDao = new Inscripcion();
        }
        public IncripcionesAspirante GuardarAspirante(IncripcionesAspirante aspirante)
        {
            return inscripcionDao.GuardarAspirante(aspirante);
        }

        public List<AspirantesInscritos> ObtenerAspirantesInscritos()
        {
            return inscripcionDao.ObtenerAspirantesInscritos();
        }
    }
}
