using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{   
    public partial class RealizarExamenFrm : Form
    {
        public int idClase { get; set; }
        public RealizarExamenFrm()
        {
            InitializeComponent();
        }

        private void RealizarExamenFrm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var preguntas = database.GetCollection<PreguntasClass>("Examen");

            List<PreguntasClass> lista = preguntas.Find(d => d.IdClase == idClase).ToList();

        }
    }
}
