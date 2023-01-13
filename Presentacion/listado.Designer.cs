namespace Presentacion
{
    partial class listado
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
            this.cerrarb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cerrarb
            // 
            this.cerrarb.Location = new System.Drawing.Point(574, 750);
            this.cerrarb.Name = "cerrarb";
            this.cerrarb.Size = new System.Drawing.Size(193, 58);
            this.cerrarb.TabIndex = 6;
            this.cerrarb.Text = "Cerrar";
            this.cerrarb.UseVisualStyleBackColor = true;
            this.cerrarb.Click += new System.EventHandler(this.cerrarb_Click);
            // 
            // listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 820);
            this.Controls.Add(this.cerrarb);
            this.Name = "listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cerrarb;
    }
}