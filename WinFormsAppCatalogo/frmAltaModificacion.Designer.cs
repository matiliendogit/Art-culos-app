namespace WinFormsAppCatalogo
{
    partial class frmAltaModificacion
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
            this.pboImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblCódigoObligatorio = new System.Windows.Forms.Label();
            this.lblNombreObligatorio = new System.Windows.Forms.Label();
            this.lblDescripObligatorio = new System.Windows.Forms.Label();
            this.lblMarcaObligatorio = new System.Windows.Forms.Label();
            this.lblCategObligatorio = new System.Windows.Forms.Label();
            this.lblPrecioObligatorio = new System.Windows.Forms.Label();
            this.btnNewMarca = new System.Windows.Forms.Button();
            this.btnNewCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboImagenArticulo
            // 
            this.pboImagenArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboImagenArticulo.Location = new System.Drawing.Point(140, 12);
            this.pboImagenArticulo.Name = "pboImagenArticulo";
            this.pboImagenArticulo.Size = new System.Drawing.Size(407, 298);
            this.pboImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenArticulo.TabIndex = 0;
            this.pboImagenArticulo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(80, 331);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 328);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(428, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 425);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(428, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(57, 428);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 375);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(428, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(80, 378);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(151, 479);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(428, 22);
            this.txtImagenUrl.TabIndex = 3;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(64, 482);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(72, 16);
            this.lblImagenUrl.TabIndex = 7;
            this.lblImagenUrl.Text = "Url Imagen";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(223, 629);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(267, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(111, 632);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(92, 16);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio ($ARS)";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(158, 533);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(137, 583);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(223, 530);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(267, 24);
            this.cboMarca.TabIndex = 5;
            this.cboMarca.Leave += new System.EventHandler(this.cboMarca_Leave);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(223, 580);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(267, 24);
            this.cboCategoria.TabIndex = 7;
            this.cboCategoria.Leave += new System.EventHandler(this.cboCategoria_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(239, 686);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 35);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 686);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExaminar.Location = new System.Drawing.Point(584, 480);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 4;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblCódigoObligatorio
            // 
            this.lblCódigoObligatorio.AutoSize = true;
            this.lblCódigoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCódigoObligatorio.Location = new System.Drawing.Point(585, 331);
            this.lblCódigoObligatorio.Name = "lblCódigoObligatorio";
            this.lblCódigoObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblCódigoObligatorio.TabIndex = 18;
            this.lblCódigoObligatorio.Text = "*";
            this.lblCódigoObligatorio.Visible = false;
            // 
            // lblNombreObligatorio
            // 
            this.lblNombreObligatorio.AutoSize = true;
            this.lblNombreObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNombreObligatorio.Location = new System.Drawing.Point(585, 379);
            this.lblNombreObligatorio.Name = "lblNombreObligatorio";
            this.lblNombreObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblNombreObligatorio.TabIndex = 19;
            this.lblNombreObligatorio.Text = "*";
            this.lblNombreObligatorio.Visible = false;
            // 
            // lblDescripObligatorio
            // 
            this.lblDescripObligatorio.AutoSize = true;
            this.lblDescripObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDescripObligatorio.Location = new System.Drawing.Point(585, 426);
            this.lblDescripObligatorio.Name = "lblDescripObligatorio";
            this.lblDescripObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblDescripObligatorio.TabIndex = 20;
            this.lblDescripObligatorio.Text = "*";
            this.lblDescripObligatorio.Visible = false;
            // 
            // lblMarcaObligatorio
            // 
            this.lblMarcaObligatorio.AutoSize = true;
            this.lblMarcaObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMarcaObligatorio.Location = new System.Drawing.Point(496, 533);
            this.lblMarcaObligatorio.Name = "lblMarcaObligatorio";
            this.lblMarcaObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblMarcaObligatorio.TabIndex = 21;
            this.lblMarcaObligatorio.Text = "*";
            this.lblMarcaObligatorio.Visible = false;
            // 
            // lblCategObligatorio
            // 
            this.lblCategObligatorio.AutoSize = true;
            this.lblCategObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCategObligatorio.Location = new System.Drawing.Point(496, 586);
            this.lblCategObligatorio.Name = "lblCategObligatorio";
            this.lblCategObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblCategObligatorio.TabIndex = 22;
            this.lblCategObligatorio.Text = "*";
            this.lblCategObligatorio.Visible = false;
            // 
            // lblPrecioObligatorio
            // 
            this.lblPrecioObligatorio.AutoSize = true;
            this.lblPrecioObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioObligatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPrecioObligatorio.Location = new System.Drawing.Point(496, 633);
            this.lblPrecioObligatorio.Name = "lblPrecioObligatorio";
            this.lblPrecioObligatorio.Size = new System.Drawing.Size(14, 18);
            this.lblPrecioObligatorio.TabIndex = 23;
            this.lblPrecioObligatorio.Text = "*";
            this.lblPrecioObligatorio.Visible = false;
            // 
            // btnNewMarca
            // 
            this.btnNewMarca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMarca.Location = new System.Drawing.Point(516, 531);
            this.btnNewMarca.Name = "btnNewMarca";
            this.btnNewMarca.Size = new System.Drawing.Size(38, 26);
            this.btnNewMarca.TabIndex = 6;
            this.btnNewMarca.Text = "+";
            this.btnNewMarca.UseVisualStyleBackColor = true;
            this.btnNewMarca.Click += new System.EventHandler(this.btnNewMarca_Click);
            // 
            // btnNewCategoria
            // 
            this.btnNewCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategoria.Location = new System.Drawing.Point(516, 579);
            this.btnNewCategoria.Name = "btnNewCategoria";
            this.btnNewCategoria.Size = new System.Drawing.Size(38, 26);
            this.btnNewCategoria.TabIndex = 8;
            this.btnNewCategoria.Text = "+";
            this.btnNewCategoria.UseVisualStyleBackColor = true;
            this.btnNewCategoria.Click += new System.EventHandler(this.btnNewCategoria_Click);
            // 
            // frmAltaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 733);
            this.Controls.Add(this.btnNewCategoria);
            this.Controls.Add(this.btnNewMarca);
            this.Controls.Add(this.lblPrecioObligatorio);
            this.Controls.Add(this.lblCategObligatorio);
            this.Controls.Add(this.lblMarcaObligatorio);
            this.Controls.Add(this.lblDescripObligatorio);
            this.Controls.Add(this.lblNombreObligatorio);
            this.Controls.Add(this.lblCódigoObligatorio);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pboImagenArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAltaModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de carga";
            this.Load += new System.EventHandler(this.AltaModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboImagenArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblCódigoObligatorio;
        private System.Windows.Forms.Label lblNombreObligatorio;
        private System.Windows.Forms.Label lblDescripObligatorio;
        private System.Windows.Forms.Label lblMarcaObligatorio;
        private System.Windows.Forms.Label lblCategObligatorio;
        private System.Windows.Forms.Label lblPrecioObligatorio;
        private System.Windows.Forms.Button btnNewMarca;
        private System.Windows.Forms.Button btnNewCategoria;
    }
}