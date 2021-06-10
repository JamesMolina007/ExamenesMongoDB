namespace PrimerProyectoTDB2
{
    partial class AdminClasesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminClasesFrm));
            this.c1Button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Clase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Button1.Image = ((System.Drawing.Image)(resources.GetObject("c1Button1.Image")));
            this.c1Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Button1.Location = new System.Drawing.Point(118, 68);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(106, 40);
            this.c1Button1.TabIndex = 5;
            this.c1Button1.Text = "&Guardar";
            this.c1Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la Clase:";
            // 
            // tb_Clase
            // 
            this.tb_Clase.Location = new System.Drawing.Point(12, 41);
            this.tb_Clase.Name = "tb_Clase";
            this.tb_Clase.Size = new System.Drawing.Size(301, 20);
            this.tb_Clase.TabIndex = 3;
            // 
            // AdminClasesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 120);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Clase);
            this.MaximizeBox = false;
            this.Name = "AdminClasesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Clases";
            this.Load += new System.EventHandler(this.AdminClasesFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c1Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Clase;
    }
}