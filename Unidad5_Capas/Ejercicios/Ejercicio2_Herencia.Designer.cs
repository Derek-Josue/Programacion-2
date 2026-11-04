namespace Unidad5_Capas.Ejercicios
{
    partial class Ejercicio2_Herencia
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
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(169, 72);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(164, 16);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Información del Estudiante";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(367, 63);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(121, 16);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año de nacimiento ";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(160, 162);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Información";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(317, 162);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 22);
            this.txtAño.TabIndex = 3;
            // 
            // Ejercicio2_Herencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblEstudiante);
            this.Name = "Ejercicio2_Herencia";
            this.Text = "Ejercicio2_Herencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtAño;
    }
}