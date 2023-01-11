namespace Presentacion
{
    partial class datoDesplegable
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
            this.datoDesplegableL = new System.Windows.Forms.Label();
            this.datoDesplegableCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datoDesplegableL
            // 
            this.datoDesplegableL.AutoSize = true;
            this.datoDesplegableL.Location = new System.Drawing.Point(12, 6);
            this.datoDesplegableL.Name = "datoDesplegableL";
            this.datoDesplegableL.Size = new System.Drawing.Size(82, 32);
            this.datoDesplegableL.TabIndex = 0;
            this.datoDesplegableL.Text = "Dato:";
            // 
            // datoDesplegableCb
            // 
            this.datoDesplegableCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datoDesplegableCb.FormattingEnabled = true;
            this.datoDesplegableCb.Location = new System.Drawing.Point(250, 3);
            this.datoDesplegableCb.Name = "datoDesplegableCb";
            this.datoDesplegableCb.Size = new System.Drawing.Size(237, 39);
            this.datoDesplegableCb.TabIndex = 1;
            // 
            // datoDesplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datoDesplegableCb);
            this.Controls.Add(this.datoDesplegableL);
            this.Name = "datoDesplegable";
            this.Size = new System.Drawing.Size(503, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datoDesplegableL;
        private System.Windows.Forms.ComboBox datoDesplegableCb;
    }
}
