namespace Presentacion
{
    partial class datos
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
            this.aceptarAlB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aceptarAlB
            // 
            this.aceptarAlB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptarAlB.Location = new System.Drawing.Point(349, 543);
            this.aceptarAlB.Margin = new System.Windows.Forms.Padding(6);
            this.aceptarAlB.Name = "aceptarAlB";
            this.aceptarAlB.Size = new System.Drawing.Size(185, 52);
            this.aceptarAlB.TabIndex = 0;
            this.aceptarAlB.Text = "Aceptar";
            this.aceptarAlB.UseVisualStyleBackColor = true;
            // 
            // datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 671);
            this.Controls.Add(this.aceptarAlB);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "datos";
            this.Text = "datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aceptarAlB;
    }
}