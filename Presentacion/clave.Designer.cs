namespace Presentacion
{
    partial class claveUC
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
            this.claveLUC = new System.Windows.Forms.Label();
            this.claveTbUC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // claveLUC
            // 
            this.claveLUC.AutoSize = true;
            this.claveLUC.Location = new System.Drawing.Point(12, 6);
            this.claveLUC.Name = "claveLUC";
            this.claveLUC.Size = new System.Drawing.Size(95, 32);
            this.claveLUC.TabIndex = 0;
            this.claveLUC.Text = "Clave:";
            // 
            // claveTbUC
            // 
            this.claveTbUC.Location = new System.Drawing.Point(250, 3);
            this.claveTbUC.Name = "claveTbUC";
            this.claveTbUC.ReadOnly = true;
            this.claveTbUC.Size = new System.Drawing.Size(237, 38);
            this.claveTbUC.TabIndex = 1;
            // 
            // claveUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.claveTbUC);
            this.Controls.Add(this.claveLUC);
            this.Name = "claveUC";
            this.Size = new System.Drawing.Size(501, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label claveLUC;
        private System.Windows.Forms.TextBox claveTbUC;
    }
}
