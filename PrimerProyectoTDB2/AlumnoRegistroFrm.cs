using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class AlumnoRegistroFrm : Form
    {
        public AlumnoRegistroFrm()
        {
            InitializeComponent();
        }

        private void c1TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlumnoRegistroFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool completo = true;
            if (tb_Contrasena.Text.Equals(null) || tb_Contrasena2.Text.Equals(null) || tb_NombreCompleto.Text.Equals(null) || tb_usuario.Text.Equals(null))
                completo = false;
            if (completo && tb_Contrasena.Text.Equals(tb_Contrasena2.Text))
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Proyecto");
                var alumnoDB = database.GetCollection<AlumnoClass>("Alumno");
                List<AlumnoClass> alumno = alumnoDB.Find(d => d.Login == tb_usuario.Text).ToList();
                if (alumno.Count > 0)
                {
                    MessageBox.Show("Usuario ya existente! Pruebe con otro!");
                }
                else
                {
                    List<AlumnoClass> lista = alumnoDB.Find(d => true).ToList();
                    string password = Encrypt.GetSHA256(tb_Contrasena.Text);
                    int max = 0;
                    foreach (var item in lista)
                    {
                        if (item.Id > max)
                            max = item.Id;
                    }
                    var AlumnoClass = new AlumnoClass
                    {
                        Id = max + 1,
                        Login = tb_usuario.Text,
                        NombreCompleto = tb_NombreCompleto.Text,
                        Contrasena = password
                    };
                    alumnoDB.InsertOne(AlumnoClass);
                    MessageBox.Show("Registrado Exitosamente");
                    this.Close();
                }
            }
        }


    }
}
