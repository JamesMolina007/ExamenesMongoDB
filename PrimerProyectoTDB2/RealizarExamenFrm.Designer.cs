namespace PrimerProyectoTDB2
{
    partial class RealizarExamenFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta,
            this.Respuesta});
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(172, 74);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pregunta
            // 
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            this.Pregunta.Width = 300;
            // 
            // Respuesta
            // 
            this.Respuesta.HeaderText = "Respuesta";
            this.Respuesta.Items.AddRange(new object[] {
            "Verdadero",
            "Falso"});
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.ReadOnly = true;
            this.Respuesta.Width = 150;
            // 
            // RealizarExamenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 426);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RealizarExamenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.RealizarExamenFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewComboBoxColumn Respuesta;
    }
}