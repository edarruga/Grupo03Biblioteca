namespace Presentacion
{
    partial class claveDesplegable
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
            this.claveDesplegableL = new System.Windows.Forms.Label();
            this.claveDesplegableCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // claveDesplegableL
            // 
            this.claveDesplegableL.AutoSize = true;
            this.claveDesplegableL.Location = new System.Drawing.Point(12, 6);
            this.claveDesplegableL.Name = "claveDesplegableL";
            this.claveDesplegableL.Size = new System.Drawing.Size(95, 32);
            this.claveDesplegableL.TabIndex = 0;
            this.claveDesplegableL.Text = "Clave:";
            // 
            // claveDesplegableCb
            // 
            this.claveDesplegableCb.FormattingEnabled = true;
            this.claveDesplegableCb.Location = new System.Drawing.Point(195, 3);
            this.claveDesplegableCb.Name = "claveDesplegableCb";
            this.claveDesplegableCb.Size = new System.Drawing.Size(237, 39);
            this.claveDesplegableCb.TabIndex = 1;
            // 
            // claveDesplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.claveDesplegableCb);
            this.Controls.Add(this.claveDesplegableL);
            this.Name = "claveDesplegable";
            this.Size = new System.Drawing.Size(468, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label claveDesplegableL;
        private System.Windows.Forms.ComboBox claveDesplegableCb;
    }
}
