using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PrimerProyectoTDB2
{
    class ExamenClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int Id { get; set; }

        [BsonElement("idClase")]
        public int IdClase { get; set; }

        [BsonElement("numeroPreguntas")]
        public int NumeroPreguntas { get; set; }

        [BsonElement("fechaAplicacion")]
        public DateTime fecha { get; set; }

    }
}
