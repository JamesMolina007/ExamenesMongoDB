using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class AdminExamenFrm : Form
    {
        public AdminExamenFrm()
        {
            InitializeComponent();
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

        private void AdminExamenFrm_Load(object sender, EventArgs e)
        {

        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            if (cb_Clase.SelectedItem != null && ne_Preguntas.Value > 0)
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Proyecto");
                var claseDB = database.GetCollection<ExamenClass>("Examen");
                List<ExamenClass> lista = claseDB.Find(d => true).ToList();
                bool existe = false;
                foreach (var item in lista)
                {
                    if (item.IdClase == ((ClasesClass)cb_Clase.SelectedItem).Id)
                        existe = true;
                }
                if (existe)
                {
                    MessageBox.Show("Esta clase ya tiene examen!!");
                }
                else
                {
                    var preguntasDB = database.GetCollection<PreguntasClass>("Preguntas");

                    List<PreguntasClass> preguntas = preguntasDB.Find(d => d.IdClase == ((ClasesClass)cb_Clase.SelectedItem).Id).ToList();

                    if ((int)ne_Preguntas.Value <= preguntas.Count)
                    {
                        int max = 0;
                        foreach (var item in lista)
                        {
                            if (item.Id > max)
                                max = item.Id;
                        }
                        var examenClass = new ExamenClass { Id = max+1, IdClase = ((ClasesClass)cb_Clase.SelectedItem).Id, NumeroPreguntas = (int)ne_Preguntas.Value };
                        claseDB.InsertOne(examenClass);
                        MessageBox.Show("Examen Guardado Exitosamente");
                        ne_Preguntas.Value = 0;
                    }
                    else
                        MessageBox.Show("No hay suficientes preguntas en el banco de preguntas de la clase!!!");
                }
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }
    }
}
