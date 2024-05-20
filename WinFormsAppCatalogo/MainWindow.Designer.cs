namespace WinFormsAppCatalogo
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltroRápido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblTituloFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblEliminarFiltros = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pboFiltroRapidoIcon = new System.Windows.Forms.PictureBox();
            this.pboEliminarIcon = new System.Windows.Forms.PictureBox();
            this.pboModifIcon = new System.Windows.Forms.PictureBox();
            this.pboAgregarIcon = new System.Windows.Forms.PictureBox();
            this.pboImagenArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFiltroRapidoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEliminarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboModifIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.AllowUserToOrderColumns = true;
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvListaArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvListaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArticulos.Location = new System.Drawing.Point(287, 124);
            this.dgvListaArticulos.MaximumSize = new System.Drawing.Size(900, 900);
            this.dgvListaArticulos.MultiSelect = false;
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.RowHeadersWidth = 51;
            this.dgvListaArticulos.RowTemplate.Height = 24;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(838, 251);
            this.dgvListaArticulos.TabIndex = 0;
            this.dgvListaArticulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaArticulos_CellMouseDoubleClick);
            this.dgvListaArticulos.SelectionChanged += new System.EventHandler(this.dgvListaArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(1178, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 39);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(1178, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 39);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(1178, 229);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 39);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblFiltroRápido
            // 
            this.lblFiltroRápido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroRápido.AutoSize = true;
            this.lblFiltroRápido.Location = new System.Drawing.Point(696, 97);
            this.lblFiltroRápido.Name = "lblFiltroRápido";
            this.lblFiltroRápido.Size = new System.Drawing.Size(81, 16);
            this.lblFiltroRápido.TabIndex = 5;
            this.lblFiltroRápido.Text = "Filtro rápido:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(783, 90);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(303, 27);
            this.txtFiltroRapido.TabIndex = 4;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(101, 468);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFiltrar.Location = new System.Drawing.Point(1043, 465);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(386, 468);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltro.Location = new System.Drawing.Point(750, 465);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(272, 22);
            this.txtFiltro.TabIndex = 7;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(690, 468);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(36, 16);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro";
            // 
            // lblTituloFiltro
            // 
            this.lblTituloFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloFiltro.AutoSize = true;
            this.lblTituloFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFiltro.Location = new System.Drawing.Point(27, 416);
            this.lblTituloFiltro.Name = "lblTituloFiltro";
            this.lblTituloFiltro.Size = new System.Drawing.Size(191, 20);
            this.lblTituloFiltro.TabIndex = 14;
            this.lblTituloFiltro.Text = "Filtrar lista de artículos: ";
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(171, 465);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(176, 24);
            this.cboCampo.TabIndex = 5;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(453, 465);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(186, 24);
            this.cboCriterio.TabIndex = 6;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // lblEliminarFiltros
            // 
            this.lblEliminarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminarFiltros.AutoSize = true;
            this.lblEliminarFiltros.LinkColor = System.Drawing.Color.Olive;
            this.lblEliminarFiltros.Location = new System.Drawing.Point(1014, 393);
            this.lblEliminarFiltros.Name = "lblEliminarFiltros";
            this.lblEliminarFiltros.Size = new System.Drawing.Size(104, 16);
            this.lblEliminarFiltros.TabIndex = 9;
            this.lblEliminarFiltros.TabStop = true;
            this.lblEliminarFiltros.Text = "> Eliminar Filtros";
            this.lblEliminarFiltros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEliminarFiltros_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(101, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 32);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "ARTICULOS TECNOLOGICOS";
            // 
            // pboFiltroRapidoIcon
            // 
            this.pboFiltroRapidoIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboFiltroRapidoIcon.Image = global::WinFormsAppCatalogo.Properties.Resources.lupa_png;
            this.pboFiltroRapidoIcon.Location = new System.Drawing.Point(1092, 95);
            this.pboFiltroRapidoIcon.Name = "pboFiltroRapidoIcon";
            this.pboFiltroRapidoIcon.Size = new System.Drawing.Size(26, 18);
            this.pboFiltroRapidoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFiltroRapidoIcon.TabIndex = 19;
            this.pboFiltroRapidoIcon.TabStop = false;
            // 
            // pboEliminarIcon
            // 
            this.pboEliminarIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboEliminarIcon.Image = global::WinFormsAppCatalogo.Properties.Resources.delete_item_product_box_icon_179240;
            this.pboEliminarIcon.Location = new System.Drawing.Point(1142, 317);
            this.pboEliminarIcon.Name = "pboEliminarIcon";
            this.pboEliminarIcon.Size = new System.Drawing.Size(31, 26);
            this.pboEliminarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboEliminarIcon.TabIndex = 18;
            this.pboEliminarIcon.TabStop = false;
            // 
            // pboModifIcon
            // 
            this.pboModifIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboModifIcon.Image = global::WinFormsAppCatalogo.Properties.Resources._4105934_document_edit_edit_document_update_write_writing_113937;
            this.pboModifIcon.Location = new System.Drawing.Point(1142, 236);
            this.pboModifIcon.Name = "pboModifIcon";
            this.pboModifIcon.Size = new System.Drawing.Size(31, 26);
            this.pboModifIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboModifIcon.TabIndex = 17;
            this.pboModifIcon.TabStop = false;
            // 
            // pboAgregarIcon
            // 
            this.pboAgregarIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboAgregarIcon.Image = global::WinFormsAppCatalogo.Properties.Resources.add_box_item_product_icon_179239;
            this.pboAgregarIcon.Location = new System.Drawing.Point(1142, 155);
            this.pboAgregarIcon.Name = "pboAgregarIcon";
            this.pboAgregarIcon.Size = new System.Drawing.Size(31, 26);
            this.pboAgregarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboAgregarIcon.TabIndex = 16;
            this.pboAgregarIcon.TabStop = false;
            // 
            // pboImagenArticulo
            // 
            this.pboImagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboImagenArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboImagenArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboImagenArticulo.Location = new System.Drawing.Point(12, 125);
            this.pboImagenArticulo.Name = "pboImagenArticulo";
            this.pboImagenArticulo.Size = new System.Drawing.Size(243, 250);
            this.pboImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenArticulo.TabIndex = 1;
            this.pboImagenArticulo.TabStop = false;
            this.pboImagenArticulo.Click += new System.EventHandler(this.pboImagenArticulo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 514);
            this.Controls.Add(this.pboFiltroRapidoIcon);
            this.Controls.Add(this.pboEliminarIcon);
            this.Controls.Add(this.pboModifIcon);
            this.Controls.Add(this.pboAgregarIcon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblEliminarFiltros);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblTituloFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRápido);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pboImagenArticulo);
            this.Controls.Add(this.dgvListaArticulos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 850);
            this.MinimumSize = new System.Drawing.Size(1326, 565);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo App ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFiltroRapidoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEliminarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboModifIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.PictureBox pboImagenArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltroRápido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblTituloFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.LinkLabel lblEliminarFiltros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pboAgregarIcon;
        private System.Windows.Forms.PictureBox pboModifIcon;
        private System.Windows.Forms.PictureBox pboEliminarIcon;
        private System.Windows.Forms.PictureBox pboFiltroRapidoIcon;
    }
}

