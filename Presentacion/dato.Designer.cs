namespace Presentacion
{
    partial class datoUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.datoLUC = new System.Windows.Forms.Label();
            this.datoTbUC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datoLUC
            // 
            this.datoLUC.AutoSize = true;
            this.datoLUC.Location = new System.Drawing.Point(12, 6);
            this.datoLUC.Name = "datoLUC";
            this.datoLUC.Size = new System.Drawing.Size(82, 32);
            this.datoLUC.TabIndex = 0;
            this.datoLUC.Text = "Dato:";
            // 
            // datoTbUC
            // 
            this.datoTbUC.Location = new System.Drawing.Point(250, 3);
            this.datoTbUC.Name = "datoTbUC";
            this.datoTbUC.Size = new System.Drawing.Size(237, 38);
            this.datoTbUC.TabIndex = 2;
            // 
            // datoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datoTbUC);
            this.Controls.Add(this.datoLUC);
            this.Name = "datoUC";
            this.Size = new System.Drawing.Size(499, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datoLUC;
        private System.Windows.Forms.TextBox datoTbUC;
    }
}
