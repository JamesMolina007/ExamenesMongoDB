using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class ExamenesRealizadosFrm : Form
    {
        public int idAlumno;
        public ExamenesRealizadosFrm()
        {
            InitializeComponent();
        }

        private void ExamenesRealizadosFrm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var alumno = database.GetCollection<AlumnoClass>("Alumno");
            var clase = database.GetCollection<ClasesClass>("Clase");
            var examen = database.GetCollection<ExamenClass>("Examen");
            List<AlumnoClass> AlumnoLista = alumno.Find(d => d.Id == idAlumno).ToList();
            List<ExamenClass> examenLista;
            List<ClasesClass> claseLista;
            if (AlumnoLista[0].Examenes != null )
                for (int i = 0; i < AlumnoLista[0].Examenes.Count; i++){
                    examenLista = examen.Find(d => d.Id == AlumnoLista[0].Examenes[i].IdExamen).ToList();
                    claseLista = clase.Find(d => d.Id == examenLista[0].IdClase).ToList();
                    dataGridView1.Rows.Insert(0, claseLista[0].NombreClase, AlumnoLista[0].Examenes[i].Nota);
                }        
        }
    }
}
