using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class ExamenesDisponiblesFrm : Form
    {
        public int idAlumno;
        private ArrayList ids = new ArrayList();
        private ArrayList idexamen = new ArrayList();
        public ExamenesDisponiblesFrm()
        {
            InitializeComponent();
        }

        private void ExamenesDisponiblesFrm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var ExamenDB = database.GetCollection<ExamenClass>("Examen");
            List<ExamenClass> lista = ExamenDB.Find(d => true).ToList();
            var claseDB = database.GetCollection<ClasesClass>("Clase");
            List<ClasesClass> lista3;

            var AlumnoDB = database.GetCollection<AlumnoClass>("Alumno");
            List<AlumnoClass> lista2 = AlumnoDB.Find(d => d.Id == idAlumno).ToList();

            foreach (var item in lista)
            {
                lista3 = claseDB.Find(d => d.Id == item.IdClase).ToList();
                if( !realizado(item, lista2)) { 
                    dataGridView1.Rows.Insert(0, lista3[0].NombreClase, item.NumeroPreguntas, (item.NumeroPreguntas * 5),item.IdClase,item.Id );
                    ids.Add(item.IdClase);
                    idexamen.Add(item.Id);
                }
            }
        }

        private bool realizado(ExamenClass lista, List<AlumnoClass> lista2)
        {
            if(lista2[0].Examenes != null)
                for (int i = 0; i < lista2[0].Examenes.Count; i++){
                    if (lista2[0].Examenes[i].IdExamen == lista.Id)
                        return true;
                }
            
            
            return false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExamenesRealizadosFrm examenesRealizados = new ExamenesRealizadosFrm();
            examenesRealizados.idAlumno = idAlumno;
            examenesRealizados.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere realizar el examen?", "Examen", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    ExamenFrm examen = new ExamenFrm();
                    examen.idClase = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value;
                    examen.idExamen = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value; ;
                    examen.idAlumno = idAlumno;
                    examen.Show();
                    this.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Debe Seleccionar un examen!!");
            }
        }
    }
}
