using Practica3_Progra3_CASO2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Practica3_Progra3_CASO2.Data
{
    public static class InscripcionRepository
    {
        private static List<Inscripcion> _inscripciones = new List<Inscripcion>();

        public static void AgregarInscripcion(Inscripcion inscripcion)
        {
            if (inscripcion != null)
            {
                _inscripciones.Add(inscripcion);
            }
        }

        public static IEnumerable<Inscripcion> ObtenerInscripciones()
        {
            return _inscripciones.AsReadOnly();
        }
    }
}