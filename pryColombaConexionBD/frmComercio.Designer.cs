namespace pryColombaConexionBD
{
    partial class frmComercio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvw = new System.Windows.Forms.ListView();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvw
            // 
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(40, 79);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(712, 334);
            this.lvw.TabIndex = 0;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(85, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 43);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Consultar Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Location = new System.Drawing.Point(620, 12);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(75, 44);
            this.btnContactos.TabIndex = 2;
            this.btnContactos.Text = "Consultar Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // frmComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContactos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.lvw);
            this.Name = "frmComercio";
            this.Text = "Comercio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnContactos;
    }
}

