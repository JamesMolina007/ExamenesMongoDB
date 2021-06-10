namespace PrimerProyectoTDB2
{
    partial class AdminFmr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFmr));
            this.btn_Pregunta = new System.Windows.Forms.Button();
            this.btn_Class = new System.Windows.Forms.Button();
            this.btn_Clase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Pregunta
            // 
            this.btn_Pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pregunta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pregunta.Image")));
            this.btn_Pregunta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pregunta.Location = new System.Drawing.Point(40, 90);
            this.btn_Pregunta.Name = "btn_Pregunta";
            this.btn_Pregunta.Size = new System.Drawing.Size(150, 68);
            this.btn_Pregunta.TabIndex = 5;
            this.btn_Pregunta.Text = "Preguntas";
            this.btn_Pregunta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Pregunta.UseVisualStyleBackColor = true;
            this.btn_Pregunta.Click += new System.EventHandler(this.btn_Pregunta_Click);
            // 
            // btn_Class
            // 
            this.btn_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class.Image = ((System.Drawing.Image)(resources.GetObject("btn_Class.Image")));
            this.btn_Class.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Class.Location = new System.Drawing.Point(40, 164);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(150, 71);
            this.btn_Class.TabIndex = 4;
            this.btn_Class.Text = "Clases";
            this.btn_Class.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Class.UseVisualStyleBackColor = true;
            this.btn_Class.Click += new System.EventHandler(this.btn_Class_Click);
            // 
            // btn_Clase
            // 
            this.btn_Clase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clase.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clase.Image")));
            this.btn_Clase.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clase.Location = new System.Drawing.Point(40, 12);
            this.btn_Clase.Name = "btn_Clase";
            this.btn_Clase.Size = new System.Drawing.Size(150, 72);
            this.btn_Clase.TabIndex = 3;
            this.btn_Clase.Text = "Examenes";
            this.btn_Clase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clase.UseVisualStyleBackColor = true;
            this.btn_Clase.Click += new System.EventHandler(this.btn_Clase_Click);
            // 
            // AdminFmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 246);
            this.Controls.Add(this.btn_Pregunta);
            this.Controls.Add(this.btn_Class);
            this.Controls.Add(this.btn_Clase);
            this.MaximizeBox = false;
            this.Name = "AdminFmr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Pregunta;
        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_Clase;
    }
}