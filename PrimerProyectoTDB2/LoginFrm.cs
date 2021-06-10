using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Form frm in Application.OpenForms)
            {
                i++;
            }
            if (i < 2)
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Proyecto");
                var Alumno = database.GetCollection<AlumnoClass>("Alumno");
                /*var prua = database.GetCollection<ExamenClass>("probar");
                PreguntasClass preguntas = new PreguntasClass()
                {
                    Descripcion = "hola",
                    IdClase = 3,
                    Id = 1,
                    respuesta = false,
                    Titulo = "no"
                };
                ExamenClass examen = new ExamenClass
                {
                    fecha = DateTime.Now,
                    Id = 1,
                    IdClase = 2,
                    NumeroPreguntas = 3,
                    pregunta = preguntas
                };
                prua.InsertOne(examen);
                //var result = database.GetCollection<RentalProperty>("Rentals");
                /*
                 * string cmdDoc = @"{
                    find: "Rentals",
                    filter: { polygons: { $geoIntersects: { $geometry: { 'type' : 'Point', 'coordinates' : [ 17.3734, 78.4738 ] } } } }
                  }"

                @{update: "Alumno",
                ,filter: {
                 */
                //string cmdDoc = @"db.Alumno.update( {'resultadoExamen': {'$exists': true}},{ $unset: {'resultadoExamen.$[]._t': 1}},{multi: true})";
                //var cmd = new JsonCommand<BsonDocument>(cmdDoc);
                //var res = database.RunCommand(cmd);
                //AlumnoClass alumnito = BsonSerializer.Deserialize<AlumnoClass>(listix[0]);
                //List<AlumnoClass> lista = ()documento.ToList();

           


                List<AlumnoClass> lista = Alumno.Find(d => d.Login == UsernameTextBox.Text).ToList();
                if (lista.Count > 0)
                {
                    
                    if (lista[0].Contrasena.Equals(Encrypt.GetSHA256(PasswordTextBox.Text)))
                    {
                        if (lista[0].Login.Equals("Admin"))
                        {
                            AdminFmr admin = new AdminFmr();
                            admin.Show();
                        }
                        else
                        {
                            ExamenesDisponiblesFrm examenesDisponibles = new ExamenesDisponiblesFrm();
                            examenesDisponibles.idAlumno = lista[0].Id;
                            examenesDisponibles.Show();

                        }
                    }
                    else
                        MessageBox.Show("Contraseña incorrecta!");
                }
                else
                {
                    MessageBox.Show("El usuario no existe!!");
                }
            }
            else
            {
                MessageBox.Show("Cierre las demás pestañas!!");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int i = 0;
            foreach (Form frm in Application.OpenForms)
            {
                i++;
            }
            if (i < 2)
            {
                AlumnoRegistroFrm alumnoRegistroFrm = new AlumnoRegistroFrm();
                alumnoRegistroFrm.Show();
            }
            else
            {
                MessageBox.Show("Cierre las demás pestañas!!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
