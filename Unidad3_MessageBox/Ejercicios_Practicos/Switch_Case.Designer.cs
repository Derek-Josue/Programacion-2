namespace Unidad3_MessageBox.Ejercicios_Practicos
{
    partial class Switch_Case
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
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNúmero
            // 
            this.txtNúmero.Location = new System.Drawing.Point(225, 141);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(100, 22);
            this.txtNúmero.TabIndex = 0;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(46, 144);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(161, 16);
            this.lblOpcion.TabIndex = 1;
            this.lblOpcion.Text = "Elija un número entre 1 y 4";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(381, 141);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Switch_Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.txtNúmero);
            this.Name = "Switch_Case";
            this.Text = "Switch_Case";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnMostrar;
    }
}