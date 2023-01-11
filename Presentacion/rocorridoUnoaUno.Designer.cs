namespace Presentacion
{
    partial class rocorridoUnoaUno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rocorridoUnoaUno));
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.MoveFirst = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.MoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.bindingSource1;
            this.bindingNavigator.CanOverflow = false;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirst,
            this.MovePrevious,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.MoveNext,
            this.MoveLast,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.MoveFirst;
            this.bindingNavigator.MoveLastItem = this.MoveLast;
            this.bindingNavigator.MoveNextItem = this.MoveNext;
            this.bindingNavigator.MovePreviousItem = this.MovePrevious;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(923, 51);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(94, 44);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // MoveFirst
            // 
            this.MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirst.Image")));
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.RightToLeftAutoMirrorImage = true;
            this.MoveFirst.Size = new System.Drawing.Size(58, 44);
            this.MoveFirst.Text = "Mover primero";
            // 
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("MovePrevious.Image")));
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.RightToLeftAutoMirrorImage = true;
            this.MovePrevious.Size = new System.Drawing.Size(58, 44);
            this.MovePrevious.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // MoveNext
            // 
            this.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNext.Image = ((System.Drawing.Image)(resources.GetObject("MoveNext.Image")));
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.RightToLeftAutoMirrorImage = true;
            this.MoveNext.Size = new System.Drawing.Size(58, 44);
            this.MoveNext.Text = "Mover siguiente";
            // 
            // MoveLast
            // 
            this.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLast.Image = ((System.Drawing.Image)(resources.GetObject("MoveLast.Image")));
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.RightToLeftAutoMirrorImage = true;
            this.MoveLast.Size = new System.Drawing.Size(58, 44);
            this.MoveLast.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // rocorridoUnoaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 684);
            this.Controls.Add(this.bindingNavigator);
            this.Name = "rocorridoUnoaUno";
            this.Text = "rocorridoUnoaUno";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton MoveFirst;
        private System.Windows.Forms.ToolStripButton MovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton MoveNext;
        private System.Windows.Forms.ToolStripButton MoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}