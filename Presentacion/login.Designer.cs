namespace Presentacion
{
    partial class login
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
            this.Continuar = new System.Windows.Forms.Button();
            this.NombreLa = new System.Windows.Forms.Label();
            this.ContrasenaLa = new System.Windows.Forms.Label();
            this.NombreTb = new System.Windows.Forms.TextBox();
            this.ContrasenaTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Continuar
            // 
            this.Continuar.Location = new System.Drawing.Point(248, 427);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(178, 53);
            this.Continuar.TabIndex = 0;
            this.Continuar.Text = "Continuar";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // NombreLa
            // 
            this.NombreLa.AutoSize = true;
            this.NombreLa.Location = new System.Drawing.Point(204, 71);
            this.NombreLa.Name = "NombreLa";
            this.NombreLa.Size = new System.Drawing.Size(262, 32);
            this.NombreLa.TabIndex = 1;
            this.NombreLa.Text = "Nombre de personal:";
            // 
            // ContrasenaLa
            // 
            this.ContrasenaLa.AutoSize = true;
            this.ContrasenaLa.Location = new System.Drawing.Point(204, 236);
            this.ContrasenaLa.Name = "ContrasenaLa";
            this.ContrasenaLa.Size = new System.Drawing.Size(169, 32);
            this.ContrasenaLa.TabIndex = 2;
            this.ContrasenaLa.Text = "Contraseña:";
            // 
            // NombreTb
            // 
            this.NombreTb.Location = new System.Drawing.Point(210, 121);
            this.NombreTb.Name = "NombreTb";
            this.NombreTb.Size = new System.Drawing.Size(256, 38);
            this.NombreTb.TabIndex = 3;
            // 
            // ContrasenaTb
            // 
            this.ContrasenaTb.Location = new System.Drawing.Point(210, 281);
            this.ContrasenaTb.Name = "ContrasenaTb";
            this.ContrasenaTb.PasswordChar = '⦁';
            this.ContrasenaTb.Size = new System.Drawing.Size(256, 38);
            this.ContrasenaTb.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 596);
            this.Controls.Add(this.ContrasenaTb);
            this.Controls.Add(this.NombreTb);
            this.Controls.Add(this.ContrasenaLa);
            this.Controls.Add(this.NombreLa);
            this.Controls.Add(this.Continuar);
            this.Name = "login";
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Label NombreLa;
        private System.Windows.Forms.Label ContrasenaLa;
        private System.Windows.Forms.TextBox NombreTb;
        private System.Windows.Forms.TextBox ContrasenaTb;
    }
}