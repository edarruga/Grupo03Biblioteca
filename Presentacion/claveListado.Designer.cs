namespace Presentacion
{
    partial class claveListado
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
            this.clavebL = new System.Windows.Forms.Button();
            this.clavelbL = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clavebL
            // 
            this.clavebL.Location = new System.Drawing.Point(26, 24);
            this.clavebL.Name = "clavebL";
            this.clavebL.Size = new System.Drawing.Size(253, 52);
            this.clavebL.TabIndex = 0;
            this.clavebL.Text = "Clave";
            this.clavebL.UseVisualStyleBackColor = true;
            // 
            // clavelbL
            // 
            this.clavelbL.FormattingEnabled = true;
            this.clavelbL.ItemHeight = 31;
            this.clavelbL.Location = new System.Drawing.Point(26, 110);
            this.clavelbL.Name = "clavelbL";
            this.clavelbL.Size = new System.Drawing.Size(253, 531);
            this.clavelbL.TabIndex = 1;
            // 
            // claveListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clavelbL);
            this.Controls.Add(this.clavebL);
            this.Name = "claveListado";
            this.Size = new System.Drawing.Size(302, 668);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clavebL;
        private System.Windows.Forms.ListBox clavelbL;
    }
}
