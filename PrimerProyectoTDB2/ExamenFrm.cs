using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrimerProyectoTDB2
{
    public partial class ExamenFrm : Form
    {
        public int idClase;
        private bool realizado = false;
        public int idAlumno;
        public int idExamen;
        private List<PreguntasClass> lista;
        private int actual;
        private ArrayList respuestas = new ArrayList();
        private bool faltantes = false;
        private bool cancelado = false;
        public ExamenFrm()
        {
            InitializeComponent();
        }

        private void ExamenFrm_Load(object sender, EventArgs e)
        {
            actual = 0;
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Proyecto");
            var PreguntasDB = database.GetCollection<PreguntasClass>("Preguntas");
            var examenDB = database.GetCollection<ExamenClass>("Examen");
            List<ExamenClass> examen = examenDB.Find(d => d.Id == idExamen).ToList();
            lista = PreguntasDB.Find(d => d.IdClase == idClase).ToList();
            lista = DesordenarLista<PreguntasClass>(lista);
            List<PreguntasClass> sublista = new List<PreguntasClass> { };
            for (int i = 0; i < examen[0].NumeroPreguntas; i++)
            {
                sublista.Add(lista[i]);
            }
            lista = sublista;
            for (int i = 1; i <= lista.Count; i++)
            {
                respuestas.Add(null);
                cb_Preguntas.Items.Add(i);
            }
            cambioLista();
        }

        private static List<PreguntasClass> DesordenarLista<PreguntasClass>(List<PreguntasClass> input)
        {
            List<PreguntasClass> arr = input;
            List<PreguntasClass> arrDes = new List<PreguntasClass>();

            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }

            return arrDes;
        }

        private void btn_Avanzar_Click(object sender, EventArgs e)
        {
            if (actual < lista.Count - 1)
            {
                cambioRespuesta();
                actual++;
                cambioLista();
            }
        }

        private void cambioLista()
        {
            lbl_Pregunta.Text = "Pregunta #" + (actual + 1).ToString();
            tb_Pregunta.Text = lista[actual].Descripcion;
            tb_Titulo.Text = lista[actual].Titulo;
            if(respuestas[actual] != null )
                if ((bool)respuestas[actual])
                    rb_Verdadero.Checked = true;
                else
                    rb_Falso.Checked = true;
            else
            {
                rb_Falso.Checked = false;
                rb_Verdadero.Checked = false;
            }
        }

        private void cambioRespuesta()
        {
            if (rb_Verdadero.Checked)
                respuestas[actual] = true;
            else if(rb_Falso.Checked)
                respuestas[actual] = false;
            else
            {
                respuestas[actual] = null;
            }
        }

        private void btn_Retroceder_Click(object sender, EventArgs e)
        {
            if (actual > 0)
            {
                cambioRespuesta();
                actual--;
                cambioLista();
            }
        }

        private void cb_Preguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambioRespuesta();
            actual = (int)cb_Preguntas.SelectedItem - 1;
            cambioLista();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            enviar();
        }

        private void ExamenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!realizado)
            {
                DialogResult dialogResult = MessageBox.Show("Si se sale el examen se enviará con lo que se guardó!!!", "Enviar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    enviar();
                    if (cancelado)
                        e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void enviar()
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere enviar el examen?", "Enviar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //if(actual == lista.Count-1 || actual == 0 )
                //{
                if (rb_Falso.Checked)
                    respuestas[actual] = false;
                else if (rb_Verdadero.Checked)
                    respuestas[actual] = true;
                //}
                foreach (var item in respuestas)
                {
                    if (item == null)
                        faltantes = true;
                }
                if (faltantes)
                    dialogResult = MessageBox.Show("Hay Preguntas Sin Contestar!!! \n ¿Seguro que quiere enviar?", "Enviar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var client = new MongoClient("mongodb://localhost:27017");
                    var database = client.GetDatabase("Proyecto");
                    var resultadosDB = database.GetCollection<AlumnoClass>("Alumno");
                    int i = 0;
                    int puntaje = 0;
                    //ArrayList<respuetas> resp = new ArrayList<respuetas> {};
                    List<respuetas> resp = new List<respuetas>();
                    
                    foreach (var item in lista)
                    {
                        if (respuestas[i] != null)
                            if ((bool)item.respuesta == (bool)respuestas[i])
                            {
                                puntaje += 5;
                            }
                        var r = new respuetas
                        {
                            idRespuesta = lista[i].Id,
                            respuesta = (bool)respuestas[i]
                        };
                        resp.Add(r);
                        i++;
                    }
                    List<AlumnoClass> alumno = resultadosDB.Find(d => d.Id == idAlumno).ToList();
                    List<ResultadoExamenClass> listaExamenes = new List<ResultadoExamenClass>();
                    if (alumno[0].Examenes != null)
                        listaExamenes = alumno[0].Examenes;
                    var result = new ResultadoExamenClass
                    {
                        IdAlumno = idAlumno,
                        IdExamen = idExamen,
                        Nota = puntaje,
                        respuestas = resp
                    };
                    listaExamenes.Add(result);
                    alumno[0].Examenes = listaExamenes;
                    //string cmdDoc = @"db.Alumno.update( {'resultadoExamen': {'$exists': true}},{ $unset: {'resultadoExamen.$[]._t': 1}},{multi: true})";
                    //var cmd = new JsonCommand<BsonDocument>(cmdDoc);
                    //var res = database.RunCommand(cmd);
                    resultadosDB.FindOneAndReplace(d => d.Id == idAlumno, alumno[0]);

                    //AlumnoClass itemA = new AlumnoClass();
                    //itemA = alumno[0];
                    //var returnDocument = new BsonDocument(itemA.ToBsonDocument());
                    //returnDocument.Remove("_t");
                    //var collection = database.GetCollection<BsonDocument>("Alumno");
                    //resultadosDB.DeleteOne(d => d.Id == idAlumno);
                    //collection.InsertOne(returnDocument);


                    //resultadosDB.InsertOne(returnDocument);
                    //resultadosDB.UpdateOne("resultadoExamen", listaExamenes);
                    //var client = new MongoClient("mongodb://localhost:27017");
                    //var database = client.GetDatabase("Proyecto");
                    //var resultadosDB = database.GetCollection<ResultadoExamenClass>("ResultadoExamen");
                    //int i = 0;
                    //int puntaje = 0;
                    //foreach (var item in lista)
                    //{
                    //    if (respuestas[i] != null)
                    //        if ((bool)item.respuesta == (bool)respuestas[i])
                    //        {
                    //            puntaje += 5;
                    //        }
                    //    i++;
                    //}
                    //var resultadoDB = database.GetCollection<ResultadoExamenClass>("ResultadoExamen");
                    //List<ResultadoExamenClass> ResultadosDB = resultadosDB.Find(d => true).ToList();
                    //var ResultadoExamenClass = new ResultadoExamenClass
                    //{
                    //    IdExamen = idExamen,
                    //    IdAlumno = idAlumno,
                    //    Nota = puntaje
                    //};
                    //resultadoDB.InsertOne(ResultadoExamenClass);
                    MessageBox.Show("Examen enviado correctamente");
                    realizado = true;
                    ExamenesDisponiblesFrm examenesDisponibles = new ExamenesDisponiblesFrm();
                    examenesDisponibles.idAlumno = idAlumno;
                    examenesDisponibles.Show();
                    cancelado = false;
                    this.Close();
                }
            }
            else
                cancelado = true;
        }
    }
}
