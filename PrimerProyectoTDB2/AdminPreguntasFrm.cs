using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class AdminPreguntasFrm : Form
    {
        int maximo = 0;
        public AdminPreguntasFrm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool completo = true;
            bool respuestaRb = false;
            if (cb_Clase.SelectedItem != null)
            {
                if (tb_Titulo.TextLength < 1 || tb_Descripcion.TextLength < 1 || cb_Clase.SelectedItem.ToString().Length < 1)
                    completo = false;
                if (completo)
                {
                    if (rb_Verdadero.Checked)
                        respuestaRb = true;
                    var client = new MongoClient("mongodb://localhost:27017");
                    var database = client.GetDatabase("Proyecto");
                    var preguntasDB = database.GetCollection<PreguntasClass>("Preguntas");

                    List<PreguntasClass> lista = preguntasDB.Find(d => true).ToList();
                    int max = 0;
                    foreach (var item in lista)
                    {
                        if (item.Id > max)
                            max = item.Id;
                    }
                    var preguntasClass = new PreguntasClass
                    {
                        Id = max + 1,
                        IdClase = ((ClasesClass)cb_Clase.SelectedItem).Id,
                        Descripcion = tb_Descripcion.Text,
                        respuesta = respuestaRb,
                        Titulo = tb_Titulo.Text
                    };
                    preguntasDB.InsertOne(preguntasClass);
                    MessageBox.Show("Pregunta Agregada Exitosamente");
                    tb_Descripcion.Text = "";
                    tb_Titulo.Text = "";
                    rb_Verdadero.Checked = true;
                    llenarTabla();
                }
                else
                {
                    MessageBox.Show("Debe completar los datos!!!");
                }
            }
            else
                MessageBox.Show("Debe seleccionar una clase!!!");
        }

        private void rb_Verdadero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminPreguntasFrm_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var claseDB = database.GetCollection<ClasesClass>("Clase");
            List<ClasesClass> lista = claseDB.Find(d => true).ToList();
            foreach (var item in lista)
            {
                cb_Clase.Items.Add(item);
            }
            cb_Clase.DisplayMember = "NombreClase";
        }

        private void cb_Clase_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var examen = database.GetCollection<ExamenClass>("Examen");
            List<ExamenClass> lista2 = examen.Find(d => d.IdClase == ((ClasesClass)cb_Clase.SelectedItem).Id).ToList();
            if (lista2.Count > 0)
                maximo = lista2[0].NumeroPreguntas;
        }

        private void llenarTabla()
        {
            dgv_Datos.Rows.Clear();
            dgv_Datos.Refresh();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var claseDB = database.GetCollection<PreguntasClass>("Preguntas");
            List<PreguntasClass> lista = claseDB.Find(d => d.IdClase == ((ClasesClass)cb_Clase.SelectedItem).Id).ToList();
            foreach (var item in lista)
            {
                dgv_Datos.Rows.Insert(0, item.Titulo, item.Descripcion, item.respuesta);
            }
        }
    }
}
