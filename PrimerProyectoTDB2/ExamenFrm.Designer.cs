namespace PrimerProyectoTDB2
{
    partial class ExamenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamenFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Falso = new System.Windows.Forms.RadioButton();
            this.rb_Verdadero = new System.Windows.Forms.RadioButton();
            this.btn_Avanzar = new System.Windows.Forms.Button();
            this.btn_Retroceder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Pregunta = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_Pregunta = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.cb_Preguntas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrucciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Falso);
            this.groupBox1.Controls.Add(this.rb_Verdadero);
            this.groupBox1.Location = new System.Drawing.Point(366, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rb_Falso
            // 
            this.rb_Falso.AutoSize = true;
            this.rb_Falso.Location = new System.Drawing.Point(7, 42);
            this.rb_Falso.Name = "rb_Falso";
            this.rb_Falso.Size = new System.Drawing.Size(50, 17);
            this.rb_Falso.TabIndex = 1;
            this.rb_Falso.TabStop = true;
            this.rb_Falso.Text = "Falso";
            this.rb_Falso.UseVisualStyleBackColor = true;
            // 
            // rb_Verdadero
            // 
            this.rb_Verdadero.AutoSize = true;
            this.rb_Verdadero.Location = new System.Drawing.Point(6, 19);
            this.rb_Verdadero.Name = "rb_Verdadero";
            this.rb_Verdadero.Size = new System.Drawing.Size(74, 17);
            this.rb_Verdadero.TabIndex = 0;
            this.rb_Verdadero.TabStop = true;
            this.rb_Verdadero.Text = "Verdadero";
            this.rb_Verdadero.UseVisualStyleBackColor = true;
            // 
            // btn_Avanzar
            // 
            this.btn_Avanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Avanzar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Avanzar.Image")));
            this.btn_Avanzar.Location = new System.Drawing.Point(475, 239);
            this.btn_Avanzar.Name = "btn_Avanzar";
            this.btn_Avanzar.Size = new System.Drawing.Size(32, 27);
            this.btn_Avanzar.TabIndex = 7;
            this.btn_Avanzar.UseVisualStyleBackColor = true;
            this.btn_Avanzar.Click += new System.EventHandler(this.btn_Avanzar_Click);
            // 
            // btn_Retroceder
            // 
            this.btn_Retroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retroceder.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retroceder.Image")));
            this.btn_Retroceder.Location = new System.Drawing.Point(369, 239);
            this.btn_Retroceder.Name = "btn_Retroceder";
            this.btn_Retroceder.Size = new System.Drawing.Size(31, 27);
            this.btn_Retroceder.TabIndex = 8;
            this.btn_Retroceder.UseVisualStyleBackColor = true;
            this.btn_Retroceder.Click += new System.EventHandler(this.btn_Retroceder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(91, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 65);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(91, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "No hay limite de tiempo para este examen";
            // 
            // lbl_Pregunta
            // 
            this.lbl_Pregunta.AutoSize = true;
            this.lbl_Pregunta.Location = new System.Drawing.Point(10, 112);
            this.lbl_Pregunta.Name = "lbl_Pregunta";
            this.lbl_Pregunta.Size = new System.Drawing.Size(60, 13);
            this.lbl_Pregunta.TabIndex = 11;
            this.lbl_Pregunta.Text = "Pregunta #";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Enabled = false;
            this.tb_Titulo.Location = new System.Drawing.Point(13, 128);
            this.tb_Titulo.Multiline = true;
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(492, 23);
            this.tb_Titulo.TabIndex = 12;
            this.tb_Titulo.Text = ".";
            // 
            // tb_Pregunta
            // 
            this.tb_Pregunta.Enabled = false;
            this.tb_Pregunta.Location = new System.Drawing.Point(13, 157);
            this.tb_Pregunta.Multiline = true;
            this.tb_Pregunta.Name = "tb_Pregunta";
            this.tb_Pregunta.Size = new System.Drawing.Size(347, 109);
            this.tb_Pregunta.TabIndex = 13;
            this.tb_Pregunta.Text = ".";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Enviar.Image")));
            this.btn_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Enviar.Location = new System.Drawing.Point(434, 12);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 27);
            this.btn_Enviar.TabIndex = 14;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // cb_Preguntas
            // 
            this.cb_Preguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Preguntas.FormattingEnabled = true;
            this.cb_Preguntas.Location = new System.Drawing.Point(406, 242);
            this.cb_Preguntas.Name = "cb_Preguntas";
            this.cb_Preguntas.Size = new System.Drawing.Size(63, 21);
            this.cb_Preguntas.TabIndex = 15;
            this.cb_Preguntas.SelectedIndexChanged += new System.EventHandler(this.cb_Preguntas_SelectedIndexChanged);
            // 
            // ExamenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 276);
            this.Controls.Add(this.cb_Preguntas);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.tb_Pregunta);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.lbl_Pregunta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Retroceder);
            this.Controls.Add(this.btn_Avanzar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ExamenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamenFrm_FormClosing);
            this.Load += new System.EventHandler(this.ExamenFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Falso;
        private System.Windows.Forms.RadioButton rb_Verdadero;
        private System.Windows.Forms.Button btn_Avanzar;
        private System.Windows.Forms.Button btn_Retroceder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Pregunta;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_Pregunta;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.ComboBox cb_Preguntas;
    }
}