using Practica3_Progra3_CASO2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Practica3_Progra3_CASO2.Data
{
    public class InscripcionRepository
    {
        private static List<Inscripcion> _inscripciones = new List<Inscripcion>();

        public void AgregarInscripcion(Inscripcion inscripcion)
        {
            if (inscripcion != null)
            {
                _inscripciones.Add(inscripcion);
            }
        }

        public IEnumerable<Inscripcion> ObtenerInscripciones()
        {
            return _inscripciones.AsReadOnly();
        }
    }
}