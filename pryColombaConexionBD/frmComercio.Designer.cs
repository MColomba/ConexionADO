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
            this.btnReadProd = new System.Windows.Forms.Button();
            this.btnReadCont = new System.Windows.Forms.Button();
            this.tabButtons = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabContactos = new System.Windows.Forms.TabPage();
            this.btnInsertProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnDeleteCont = new System.Windows.Forms.Button();
            this.btnEditCont = new System.Windows.Forms.Button();
            this.btnAddCont = new System.Windows.Forms.Button();
            this.tabButtons.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabContactos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw
            // 
            this.lvw.HideSelection = false;
            this.lvw.Location = new System.Drawing.Point(40, 96);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(712, 317);
            this.lvw.TabIndex = 0;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.List;
            // 
            // btnReadProd
            // 
            this.btnReadProd.Location = new System.Drawing.Point(6, 6);
            this.btnReadProd.Name = "btnReadProd";
            this.btnReadProd.Size = new System.Drawing.Size(75, 44);
            this.btnReadProd.TabIndex = 1;
            this.btnReadProd.Text = "Consultar Productos";
            this.btnReadProd.UseVisualStyleBackColor = true;
            this.btnReadProd.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnReadCont
            // 
            this.btnReadCont.Location = new System.Drawing.Point(6, 6);
            this.btnReadCont.Name = "btnReadCont";
            this.btnReadCont.Size = new System.Drawing.Size(75, 44);
            this.btnReadCont.TabIndex = 2;
            this.btnReadCont.Text = "Consultar Contactos";
            this.btnReadCont.UseVisualStyleBackColor = true;
            this.btnReadCont.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // tabButtons
            // 
            this.tabButtons.Controls.Add(this.tabProductos);
            this.tabButtons.Controls.Add(this.tabContactos);
            this.tabButtons.Location = new System.Drawing.Point(40, 12);
            this.tabButtons.Name = "tabButtons";
            this.tabButtons.SelectedIndex = 0;
            this.tabButtons.Size = new System.Drawing.Size(712, 82);
            this.tabButtons.TabIndex = 3;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.btnDeleteProd);
            this.tabProductos.Controls.Add(this.btnEditProd);
            this.tabProductos.Controls.Add(this.btnInsertProd);
            this.tabProductos.Controls.Add(this.btnReadProd);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(704, 56);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabContactos
            // 
            this.tabContactos.Controls.Add(this.btnAddCont);
            this.tabContactos.Controls.Add(this.btnEditCont);
            this.tabContactos.Controls.Add(this.btnDeleteCont);
            this.tabContactos.Controls.Add(this.btnReadCont);
            this.tabContactos.Location = new System.Drawing.Point(4, 22);
            this.tabContactos.Name = "tabContactos";
            this.tabContactos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContactos.Size = new System.Drawing.Size(704, 56);
            this.tabContactos.TabIndex = 1;
            this.tabContactos.Text = "Contactos";
            this.tabContactos.UseVisualStyleBackColor = true;
            // 
            // btnInsertProd
            // 
            this.btnInsertProd.Location = new System.Drawing.Point(87, 6);
            this.btnInsertProd.Name = "btnInsertProd";
            this.btnInsertProd.Size = new System.Drawing.Size(75, 44);
            this.btnInsertProd.TabIndex = 2;
            this.btnInsertProd.Text = "Agregar Productos";
            this.btnInsertProd.UseVisualStyleBackColor = true;
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(168, 6);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 44);
            this.btnEditProd.TabIndex = 3;
            this.btnEditProd.Text = "Editar Productos";
            this.btnEditProd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(249, 6);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteProd.TabIndex = 4;
            this.btnDeleteProd.Text = "Eliminar Productos";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCont
            // 
            this.btnDeleteCont.Location = new System.Drawing.Point(249, 6);
            this.btnDeleteCont.Name = "btnDeleteCont";
            this.btnDeleteCont.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteCont.TabIndex = 3;
            this.btnDeleteCont.Text = "Eliminar Contactos";
            this.btnDeleteCont.UseVisualStyleBackColor = true;
            // 
            // btnEditCont
            // 
            this.btnEditCont.Location = new System.Drawing.Point(168, 6);
            this.btnEditCont.Name = "btnEditCont";
            this.btnEditCont.Size = new System.Drawing.Size(75, 44);
            this.btnEditCont.TabIndex = 4;
            this.btnEditCont.Text = "Editar Contactos";
            this.btnEditCont.UseVisualStyleBackColor = true;
            // 
            // btnAddCont
            // 
            this.btnAddCont.Location = new System.Drawing.Point(87, 6);
            this.btnAddCont.Name = "btnAddCont";
            this.btnAddCont.Size = new System.Drawing.Size(75, 44);
            this.btnAddCont.TabIndex = 5;
            this.btnAddCont.Text = "Agregar Contactos";
            this.btnAddCont.UseVisualStyleBackColor = true;
            // 
            // frmComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabButtons);
            this.Controls.Add(this.lvw);
            this.Name = "frmComercio";
            this.Text = "Comercio";
            this.tabButtons.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabContactos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.Button btnReadProd;
        private System.Windows.Forms.Button btnReadCont;
        private System.Windows.Forms.TabControl tabButtons;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabContactos;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnInsertProd;
        private System.Windows.Forms.Button btnAddCont;
        private System.Windows.Forms.Button btnEditCont;
        private System.Windows.Forms.Button btnDeleteCont;
    }
}

