namespace Unidad2_operadores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConsultaedad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnMostrarValidacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsultaedad
            // 
            this.lblConsultaedad.AutoSize = true;
            this.lblConsultaedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaedad.Location = new System.Drawing.Point(126, 148);
            this.lblConsultaedad.Name = "lblConsultaedad";
            this.lblConsultaedad.Size = new System.Drawing.Size(152, 25);
            this.lblConsultaedad.TabIndex = 0;
            this.lblConsultaedad.Text = "Ingrese su edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(297, 151);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(114, 22);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // btnMostrarValidacion
            // 
            this.btnMostrarValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarValidacion.Location = new System.Drawing.Point(307, 195);
            this.btnMostrarValidacion.Name = "btnMostrarValidacion";
            this.btnMostrarValidacion.Size = new System.Drawing.Size(104, 51);
            this.btnMostrarValidacion.TabIndex = 2;
            this.btnMostrarValidacion.Text = "Mostrar";
            this.btnMostrarValidacion.UseVisualStyleBackColor = true;
            this.btnMostrarValidacion.Click += new System.EventHandler(this.btnMostrarValidacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarValidacion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblConsultaedad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaedad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnMostrarValidacion;
    }
}

