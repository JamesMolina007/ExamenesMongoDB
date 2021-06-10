using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections;
using System.Collections.Generic;

namespace PrimerProyectoTDB2
{
    class AlumnoClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int Id { get; set; }

        [BsonElement("nombreCompleto")]
        public string NombreCompleto { get; set; }

        [BsonElement("login")]
        public string Login { get; set; }

        [BsonElement("contrasena")]
        public string Contrasena { get; set; }

        [BsonElement("resultadoExamen")]
        public List<ResultadoExamenClass> Examenes { get; set; }
    }
}
