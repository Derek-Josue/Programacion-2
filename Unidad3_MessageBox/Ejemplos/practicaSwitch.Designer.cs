namespace Unidad3_MessageBox.Ejemplos
{
    partial class practicaSwitch
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
            this.btnDiadeSemana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiadeSemana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDiadeSemana
            // 
            this.btnDiadeSemana.Location = new System.Drawing.Point(402, 112);
            this.btnDiadeSemana.Name = "btnDiadeSemana";
            this.btnDiadeSemana.Size = new System.Drawing.Size(75, 23);
            this.btnDiadeSemana.TabIndex = 0;
            this.btnDiadeSemana.Text = "Mostrar";
            this.btnDiadeSemana.UseVisualStyleBackColor = true;
            this.btnDiadeSemana.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el número de un día de la semana ";
            // 
            // txtDiadeSemana
            // 
            this.txtDiadeSemana.Location = new System.Drawing.Point(296, 112);
            this.txtDiadeSemana.Name = "txtDiadeSemana";
            this.txtDiadeSemana.Size = new System.Drawing.Size(100, 22);
            this.txtDiadeSemana.TabIndex = 3;
            // 
            // practicaSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 229);
            this.Controls.Add(this.txtDiadeSemana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiadeSemana);
            this.Name = "practicaSwitch";
            this.Text = "PracticaSwitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiadeSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiadeSemana;
    }
}