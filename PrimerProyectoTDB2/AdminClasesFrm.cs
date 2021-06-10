using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class AdminClasesFrm : Form
    {
        public AdminClasesFrm()
        {
            InitializeComponent();
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var claseDB = database.GetCollection<ClasesClass>("Clase");

            List<ClasesClass> busqueda = claseDB.Find(d => d.NombreClase.ToLower() == tb_Clase.Text.ToLower() ).ToList();
            if ( busqueda.Count < 1)
            {
                List<ClasesClass> lista = claseDB.Find(d => true).ToList();
                int max = 0;
                foreach (var item in lista)
                {
                    if (item.Id > max)
                        max = item.Id;
                }
                var ClasesClass = new ClasesClass { Id = max+1, NombreClase = tb_Clase.Text };
                claseDB.InsertOne(ClasesClass);
                MessageBox.Show("Clase Guardada Exitosamente");
            }
            else
            {
                MessageBox.Show("Ya existe esta clase");
            }
            tb_Clase.Text = "";
        }

        private void AdminClasesFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
