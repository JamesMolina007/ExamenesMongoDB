namespace PrimerProyectoTDB2
{
    partial class AdminExamenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminExamenFrm));
            this.c1Button1 = new System.Windows.Forms.Button();
            this.cb_Clase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ne_Preguntas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ne_Preguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Button1.Image = ((System.Drawing.Image)(resources.GetObject("c1Button1.Image")));
            this.c1Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.c1Button1.Location = new System.Drawing.Point(68, -1);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(134, 59);
            this.c1Button1.TabIndex = 9;
            this.c1Button1.Text = "&Crear Examen";
            this.c1Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // cb_Clase
            // 
            this.cb_Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Clase.Location = new System.Drawing.Point(15, 155);
            this.cb_Clase.Name = "cb_Clase";
            this.cb_Clase.Size = new System.Drawing.Size(236, 21);
            this.cb_Clase.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clase:";
            // 
            // ne_Preguntas
            // 
            this.ne_Preguntas.Location = new System.Drawing.Point(15, 97);
            this.ne_Preguntas.Name = "ne_Preguntas";
            this.ne_Preguntas.Size = new System.Drawing.Size(236, 20);
            this.ne_Preguntas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número de Preguntas:";
            // 
            // AdminExamenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 188);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.cb_Clase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ne_Preguntas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AdminExamenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Examen";
            this.Load += new System.EventHandler(this.AdminExamenFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ne_Preguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c1Button1;
        private System.Windows.Forms.ComboBox cb_Clase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ne_Preguntas;
        private System.Windows.Forms.Label label1;
    }
}