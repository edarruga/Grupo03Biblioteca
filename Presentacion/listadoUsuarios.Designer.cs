namespace Presentacion
{
    partial class listadoUsuarios
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
            this.dnib = new System.Windows.Forms.Button();
            this.nombreb = new System.Windows.Forms.Button();
            this.apellidosb = new System.Windows.Forms.Button();
            this.dniLb = new System.Windows.Forms.ListBox();
            this.nombreLb = new System.Windows.Forms.ListBox();
            this.apellidosLb = new System.Windows.Forms.ListBox();
            this.cerrarb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dnib
            // 
            this.dnib.Location = new System.Drawing.Point(144, 68);
            this.dnib.Name = "dnib";
            this.dnib.Size = new System.Drawing.Size(219, 51);
            this.dnib.TabIndex = 0;
            this.dnib.Text = "DNI";
            this.dnib.UseVisualStyleBackColor = true;
            this.dnib.Click += new System.EventHandler(this.dnib_Click);
            // 
            // nombreb
            // 
            this.nombreb.Location = new System.Drawing.Point(433, 68);
            this.nombreb.Name = "nombreb";
            this.nombreb.Size = new System.Drawing.Size(209, 51);
            this.nombreb.TabIndex = 1;
            this.nombreb.Text = "Nombre";
            this.nombreb.UseVisualStyleBackColor = true;
            this.nombreb.Click += new System.EventHandler(this.nombreb_Click);
            // 
            // apellidosb
            // 
            this.apellidosb.Location = new System.Drawing.Point(711, 68);
            this.apellidosb.Name = "apellidosb";
            this.apellidosb.Size = new System.Drawing.Size(219, 51);
            this.apellidosb.TabIndex = 2;
            this.apellidosb.Text = "Apellidos";
            this.apellidosb.UseVisualStyleBackColor = true;
            this.apellidosb.Click += new System.EventHandler(this.apellidosb_Click);
            // 
            // dniLb
            // 
            this.dniLb.FormattingEnabled = true;
            this.dniLb.ItemHeight = 31;
            this.dniLb.Location = new System.Drawing.Point(144, 158);
            this.dniLb.Name = "dniLb";
            this.dniLb.Size = new System.Drawing.Size(219, 500);
            this.dniLb.TabIndex = 3;
            // 
            // nombreLb
            // 
            this.nombreLb.FormattingEnabled = true;
            this.nombreLb.ItemHeight = 31;
            this.nombreLb.Location = new System.Drawing.Point(433, 158);
            this.nombreLb.Name = "nombreLb";
            this.nombreLb.Size = new System.Drawing.Size(209, 500);
            this.nombreLb.TabIndex = 4;
            // 
            // apellidosLb
            // 
            this.apellidosLb.FormattingEnabled = true;
            this.apellidosLb.ItemHeight = 31;
            this.apellidosLb.Location = new System.Drawing.Point(711, 158);
            this.apellidosLb.Name = "apellidosLb";
            this.apellidosLb.Size = new System.Drawing.Size(219, 500);
            this.apellidosLb.TabIndex = 5;
            // 
            // cerrarb
            // 
            this.cerrarb.Location = new System.Drawing.Point(433, 679);
            this.cerrarb.Name = "cerrarb";
            this.cerrarb.Size = new System.Drawing.Size(209, 51);
            this.cerrarb.TabIndex = 6;
            this.cerrarb.Text = "Cerrar";
            this.cerrarb.UseVisualStyleBackColor = true;
            this.cerrarb.Click += new System.EventHandler(this.cerrarb_Click);
            // 
            // listadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 769);
            this.Controls.Add(this.cerrarb);
            this.Controls.Add(this.apellidosLb);
            this.Controls.Add(this.nombreLb);
            this.Controls.Add(this.dniLb);
            this.Controls.Add(this.apellidosb);
            this.Controls.Add(this.nombreb);
            this.Controls.Add(this.dnib);
            this.Name = "listadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dnib;
        private System.Windows.Forms.Button nombreb;
        private System.Windows.Forms.Button apellidosb;
        private System.Windows.Forms.ListBox dniLb;
        private System.Windows.Forms.ListBox nombreLb;
        private System.Windows.Forms.ListBox apellidosLb;
        private System.Windows.Forms.Button cerrarb;
    }
}