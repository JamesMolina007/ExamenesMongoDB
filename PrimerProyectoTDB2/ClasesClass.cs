using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections;

namespace PrimerProyectoTDB2
{
    class ClasesClass
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public int Id { get; set; }

        [BsonElement("nombreClase")]
        public string NombreClase { get; set; }

        [BsonElement("examenes")]
        public ArrayList Examenes { get; set; }
    }
}
