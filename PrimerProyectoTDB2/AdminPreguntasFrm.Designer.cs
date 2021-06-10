namespace PrimerProyectoTDB2
{
    partial class AdminPreguntasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPreguntasFrm));
            this.Datos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Falso = new System.Windows.Forms.RadioButton();
            this.rb_Verdadero = new System.Windows.Forms.RadioButton();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Clase = new System.Windows.Forms.ComboBox();
            this.Datos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.groupBox2);
            this.Datos.Controls.Add(this.tb_Descripcion);
            this.Datos.Controls.Add(this.tb_Titulo);
            this.Datos.Location = new System.Drawing.Point(11, 57);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(200, 270);
            this.Datos.TabIndex = 5;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Falso);
            this.groupBox2.Controls.Add(this.rb_Verdadero);
            this.groupBox2.Location = new System.Drawing.Point(0, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respuesta";
            // 
            // rb_Falso
            // 
            this.rb_Falso.AutoSize = true;
            this.rb_Falso.Location = new System.Drawing.Point(15, 42);
            this.rb_Falso.Name = "rb_Falso";
            this.rb_Falso.Size = new System.Drawing.Size(50, 17);
            this.rb_Falso.TabIndex = 3;
            this.rb_Falso.Text = "Falso";
            this.rb_Falso.UseVisualStyleBackColor = true;
            // 
            // rb_Verdadero
            // 
            this.rb_Verdadero.AutoSize = true;
            this.rb_Verdadero.Checked = true;
            this.rb_Verdadero.Location = new System.Drawing.Point(15, 19);
            this.rb_Verdadero.Name = "rb_Verdadero";
            this.rb_Verdadero.Size = new System.Drawing.Size(74, 17);
            this.rb_Verdadero.TabIndex = 2;
            this.rb_Verdadero.TabStop = true;
            this.rb_Verdadero.Text = "Verdadero";
            this.rb_Verdadero.UseVisualStyleBackColor = true;
            this.rb_Verdadero.CheckedChanged += new System.EventHandler(this.rb_Verdadero_CheckedChanged);
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(11, 101);
            this.tb_Descripcion.Multiline = true;
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(179, 81);
            this.tb_Descripcion.TabIndex = 1;
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Location = new System.Drawing.Point(11, 48);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(179, 20);
            this.tb_Titulo.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 54);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(104, 51);
            this.toolStripButton2.Text = "Agregar Pregunta";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 51);
            this.toolStripLabel1.Text = "Clase:";
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.AllowUserToDeleteRows = false;
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.Respuesta});
            this.dgv_Datos.Location = new System.Drawing.Point(217, 57);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.ReadOnly = true;
            this.dgv_Datos.Size = new System.Drawing.Size(619, 270);
            this.dgv_Datos.TabIndex = 3;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Respuesta
            // 
            this.Respuesta.HeaderText = "Respuesta";
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.ReadOnly = true;
            // 
            // cb_Clase
            // 
            this.cb_Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Clase.FormattingEnabled = true;
            this.cb_Clase.Location = new System.Drawing.Point(161, 15);
            this.cb_Clase.Name = "cb_Clase";
            this.cb_Clase.Size = new System.Drawing.Size(157, 21);
            this.cb_Clase.TabIndex = 6;
            this.cb_Clase.SelectedIndexChanged += new System.EventHandler(this.cb_Clase_SelectedIndexChanged);
            // 
            // AdminPreguntasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 341);
            this.Controls.Add(this.cb_Clase);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_Datos);
            this.MaximizeBox = false;
            this.Name = "AdminPreguntasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Preguntas";
            this.Load += new System.EventHandler(this.AdminPreguntasFrm_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Falso;
        private System.Windows.Forms.RadioButton rb_Verdadero;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
        private System.Windows.Forms.ComboBox cb_Clase;
    }
}