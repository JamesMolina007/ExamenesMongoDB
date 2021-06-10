using MongoDB.Bson.Serialization.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace PrimerProyectoTDB2
{
    class ResultadoExamenClass
    { 
        public int IdExamen { get; set; }
        public int IdAlumno { get; set; }
        public int Nota { get; set; }
        public List<respuetas> respuestas { get; set; }
    }


}
