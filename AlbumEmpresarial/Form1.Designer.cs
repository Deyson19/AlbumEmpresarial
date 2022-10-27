namespace AlbumEmpresarial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.idImagen = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcionImagen = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fechaEvento = new System.Windows.Forms.Label();
            this.lugarEvento = new System.Windows.Forms.Label();
            this.descripcionEvento = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.datePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEvento = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnCargar = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnImgSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnImgAnterior = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCampos = new FontAwesome.Sharp.IconButton();
            this.panelOcultarId = new System.Windows.Forms.Panel();
            this.btnMostrarBuscarId = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panelOcultarId.SuspendLayout();
            this.SuspendLayout();
            // 
            // idImagen
            // 
            resources.ApplyResources(this.idImagen, "idImagen");
            this.idImagen.Name = "idImagen";
            // 
            // descripcion
            // 
            resources.ApplyResources(this.descripcion, "descripcion");
            this.descripcion.Name = "descripcion";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // txtDescripcionImagen
            // 
            this.txtDescripcionImagen.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDescripcionImagen.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtDescripcionImagen, "txtDescripcionImagen");
            this.txtDescripcionImagen.Name = "txtDescripcionImagen";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pbImagen, "pbImagen");
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fechaEvento
            // 
            resources.ApplyResources(this.fechaEvento, "fechaEvento");
            this.fechaEvento.Name = "fechaEvento";
            // 
            // lugarEvento
            // 
            resources.ApplyResources(this.lugarEvento, "lugarEvento");
            this.lugarEvento.Name = "lugarEvento";
            // 
            // descripcionEvento
            // 
            resources.ApplyResources(this.descripcionEvento, "descripcionEvento");
            this.descripcionEvento.Name = "descripcionEvento";
            // 
            // txtLugar
            // 
            this.txtLugar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtLugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtLugar, "txtLugar");
            this.txtLugar.Name = "txtLugar";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDescripcionEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtDescripcionEvento, "txtDescripcionEvento");
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.datePickerFecha, "datePickerFecha");
            this.datePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFecha.MaxDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.datePickerFecha.MinDate = new System.DateTime(1940, 2, 6, 0, 0, 0, 0);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            this.datePickerFecha.ValueChanged += new System.EventHandler(this.datePickerFecha_ValueChanged);
            // 
            // lblFechaEvento
            // 
            resources.ApplyResources(this.lblFechaEvento, "lblFechaEvento");
            this.lblFechaEvento.Name = "lblFechaEvento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCargar, "btnCargar");
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnCargar.IconColor = System.Drawing.Color.Lavender;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 35;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSeleccionar, "btnSeleccionar");
            this.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSeleccionar.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionar.IconSize = 30;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnActualizar, "btnActualizar");
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnActualizar.IconColor = System.Drawing.Color.Lavender;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnImgSiguiente
            // 
            this.btnImgSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImgSiguiente.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnImgSiguiente, "btnImgSiguiente");
            this.btnImgSiguiente.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnImgSiguiente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(166)))), ((int)(((byte)(241)))));
            this.btnImgSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImgSiguiente.IconSize = 35;
            this.btnImgSiguiente.Name = "btnImgSiguiente";
            this.btnImgSiguiente.UseVisualStyleBackColor = true;
            this.btnImgSiguiente.Click += new System.EventHandler(this.btnImgSiguiente_Click);
            // 
            // btnImgAnterior
            // 
            this.btnImgAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgAnterior.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnImgAnterior, "btnImgAnterior");
            this.btnImgAnterior.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnImgAnterior.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(166)))), ((int)(((byte)(241)))));
            this.btnImgAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImgAnterior.IconSize = 35;
            this.btnImgAnterior.Name = "btnImgAnterior";
            this.btnImgAnterior.UseVisualStyleBackColor = true;
            this.btnImgAnterior.Click += new System.EventHandler(this.btnImgAnterior_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLimpiarCampos, "btnLimpiarCampos");
            this.btnLimpiarCampos.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLimpiarCampos.IconColor = System.Drawing.Color.Yellow;
            this.btnLimpiarCampos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCampos.IconSize = 35;
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // panelOcultarId
            // 
            this.panelOcultarId.Controls.Add(this.btnMostrarBuscarId);
            resources.ApplyResources(this.panelOcultarId, "panelOcultarId");
            this.panelOcultarId.Name = "panelOcultarId";
            // 
            // btnMostrarBuscarId
            // 
            this.btnMostrarBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarBuscarId.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMostrarBuscarId, "btnMostrarBuscarId");
            this.btnMostrarBuscarId.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnMostrarBuscarId.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMostrarBuscarId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarBuscarId.IconSize = 35;
            this.btnMostrarBuscarId.Name = "btnMostrarBuscarId";
            this.btnMostrarBuscarId.UseVisualStyleBackColor = true;
            this.btnMostrarBuscarId.Click += new System.EventHandler(this.btnMostrarBuscarId_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panelOcultarId);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnImgAnterior);
            this.Controls.Add(this.btnImgSiguiente);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFechaEvento);
            this.Controls.Add(this.datePickerFecha);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.descripcionEvento);
            this.Controls.Add(this.lugarEvento);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtDescripcionImagen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.idImagen);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(173)))), ((int)(((byte)(187)))));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panelOcultarId.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idImagen;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcionImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fechaEvento;
        private System.Windows.Forms.Label lugarEvento;
        private System.Windows.Forms.Label descripcionEvento;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.DateTimePicker datePickerFecha;
        private System.Windows.Forms.Label lblFechaEvento;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCargar;
        private FontAwesome.Sharp.IconButton btnSeleccionar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnImgSiguiente;
        private FontAwesome.Sharp.IconButton btnImgAnterior;
        private FontAwesome.Sharp.IconButton btnLimpiarCampos;
        private System.Windows.Forms.Panel panelOcultarId;
        private FontAwesome.Sharp.IconButton btnMostrarBuscarId;
    }
}
