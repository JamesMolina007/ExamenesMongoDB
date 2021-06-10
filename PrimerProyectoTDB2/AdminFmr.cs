using System;

using System.Windows.Forms;

namespace PrimerProyectoTDB2
{
    public partial class AdminFmr : Form
    {
        public AdminFmr()
        {
            InitializeComponent();
        }

        private void btn_Clase_Click(object sender, EventArgs e)
        {
            if (pantallasAbiertas() < 3)
            {
                AdminExamenFrm adminExamen = new AdminExamenFrm();
                adminExamen.Show();
            }
            else
                mensaje();
        }

        private void btn_Pregunta_Click(object sender, EventArgs e)
        {
            if (pantallasAbiertas() < 3)
            {
                AdminPreguntasFrm adminPreguntas = new AdminPreguntasFrm();
                adminPreguntas.Show();
            }
            else
                mensaje();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            if (pantallasAbiertas() < 3)
            {
                AdminClasesFrm adminClases = new AdminClasesFrm();
                adminClases.Show();
            }
            else
                mensaje();
        }

        private int pantallasAbiertas()
        {
            int i = 0;
            foreach (Form frm in Application.OpenForms)
            {
                i++;
            }
            return i;
        }

        private void mensaje()
        {
            MessageBox.Show("Cierre las otras pestañas!!!"); 
        }
    }
}
