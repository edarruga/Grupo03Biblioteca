namespace Presentacion
{
    partial class Introducir
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
            this.claveL = new System.Windows.Forms.Label();
            this.claveTb = new System.Windows.Forms.TextBox();
            this.aceptarB = new System.Windows.Forms.Button();
            this.cancelarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // claveL
            // 
            this.claveL.AutoSize = true;
            this.claveL.Location = new System.Drawing.Point(192, 198);
            this.claveL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.claveL.Name = "claveL";
            this.claveL.Size = new System.Drawing.Size(95, 32);
            this.claveL.TabIndex = 0;
            this.claveL.Text = "Clave:";
            // 
            // claveTb
            // 
            this.claveTb.Location = new System.Drawing.Point(382, 192);
            this.claveTb.Margin = new System.Windows.Forms.Padding(6);
            this.claveTb.Name = "claveTb";
            this.claveTb.Size = new System.Drawing.Size(328, 38);
            this.claveTb.TabIndex = 1;
            // 
            // aceptarB
            // 
            this.aceptarB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptarB.Location = new System.Drawing.Point(160, 506);
            this.aceptarB.Margin = new System.Windows.Forms.Padding(6);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(238, 55);
            this.aceptarB.TabIndex = 2;
            this.aceptarB.Text = "Aceptar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.aceptarB_Click);
            // 
            // cancelarB
            // 
            this.cancelarB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarB.Location = new System.Drawing.Point(486, 506);
            this.cancelarB.Margin = new System.Windows.Forms.Padding(6);
            this.cancelarB.Name = "cancelarB";
            this.cancelarB.Size = new System.Drawing.Size(228, 55);
            this.cancelarB.TabIndex = 3;
            this.cancelarB.Text = "Cancelar";
            this.cancelarB.UseVisualStyleBackColor = true;
            this.cancelarB.Click += new System.EventHandler(this.cancelarB_Click);
            // 
            // Introducir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 800);
            this.Controls.Add(this.cancelarB);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.claveTb);
            this.Controls.Add(this.claveL);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Introducir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introducir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label claveL;
        private System.Windows.Forms.TextBox claveTb;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.Button cancelarB;
    }
}