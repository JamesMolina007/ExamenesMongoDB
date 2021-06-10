using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PrimerProyectoTDB2
{
    class PreguntasClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int Id { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descripción")]
        public string Descripcion { get; set; }

        [BsonElement("idClase")]
        public int IdClase { get; set; }

        [BsonElement("respuesta")]
        public bool respuesta { get; set; }
    }
}
