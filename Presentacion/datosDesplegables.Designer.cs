namespace Presentacion
{
    partial class datosDesplegables
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
            this.components = new System.ComponentModel.Container();
            this.aceptarAlB = new System.Windows.Forms.Button();
            this.claveL = new System.Windows.Forms.Label();
            this.claveDesplegableCb = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptarAlB
            // 
            this.aceptarAlB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptarAlB.Location = new System.Drawing.Point(349, 543);
            this.aceptarAlB.Margin = new System.Windows.Forms.Padding(6);
            this.aceptarAlB.Name = "aceptarAlB";
            this.aceptarAlB.Size = new System.Drawing.Size(185, 52);
            this.aceptarAlB.TabIndex = 1;
            this.aceptarAlB.Text = "Aceptar";
            this.aceptarAlB.UseVisualStyleBackColor = true;
            this.aceptarAlB.Click += new System.EventHandler(this.aceptarAlB_Click);
            // 
            // claveL
            // 
            this.claveL.AutoSize = true;
            this.claveL.Location = new System.Drawing.Point(230, 120);
            this.claveL.Name = "claveL";
            this.claveL.Size = new System.Drawing.Size(95, 32);
            this.claveL.TabIndex = 2;
            this.claveL.Text = "Clave:";
            // 
            // claveDesplegableCb
            // 
            this.claveDesplegableCb.DataSource = this.bindingSource1;
            this.claveDesplegableCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.claveDesplegableCb.FormattingEnabled = true;
            this.claveDesplegableCb.Location = new System.Drawing.Point(480, 117);
            this.claveDesplegableCb.Name = "claveDesplegableCb";
            this.claveDesplegableCb.Size = new System.Drawing.Size(237, 39);
            this.claveDesplegableCb.TabIndex = 3;
            // 
            // datosDesplegables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 671);
            this.Controls.Add(this.claveDesplegableCb);
            this.Controls.Add(this.claveL);
            this.Controls.Add(this.aceptarAlB);
            this.Name = "datosDesplegables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datosDesplegables";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarAlB;
        private System.Windows.Forms.Label claveL;
        private System.Windows.Forms.ComboBox claveDesplegableCb;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}