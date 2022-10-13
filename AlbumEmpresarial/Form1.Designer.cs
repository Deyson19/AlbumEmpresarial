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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // idImagen
            // 
            this.idImagen.AutoSize = true;
            this.idImagen.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idImagen.Location = new System.Drawing.Point(10, 26);
            this.idImagen.Name = "idImagen";
            this.idImagen.Size = new System.Drawing.Size(63, 17);
            this.idImagen.TabIndex = 0;
            this.idImagen.Text = "Id Imagen:";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descripcion.Location = new System.Drawing.Point(445, 20);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(144, 17);
            this.descripcion.TabIndex = 1;
            this.descripcion.Text = "Descripcion de la Imagen:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Location = new System.Drawing.Point(127, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 23);
            this.txtId.TabIndex = 2;
            // 
            // txtDescripcionImagen
            // 
            this.txtDescripcionImagen.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDescripcionImagen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionImagen.Location = new System.Drawing.Point(591, 12);
            this.txtDescripcionImagen.Multiline = true;
            this.txtDescripcionImagen.Name = "txtDescripcionImagen";
            this.txtDescripcionImagen.Size = new System.Drawing.Size(248, 52);
            this.txtDescripcionImagen.TabIndex = 3;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Gold;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Location = new System.Drawing.Point(155, 160);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(518, 308);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 4;
            this.pbImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fechaEvento
            // 
            this.fechaEvento.AutoSize = true;
            this.fechaEvento.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fechaEvento.Location = new System.Drawing.Point(10, 71);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(84, 17);
            this.fechaEvento.TabIndex = 8;
            this.fechaEvento.Text = "Fecha Evento:";
            // 
            // lugarEvento
            // 
            this.lugarEvento.AutoSize = true;
            this.lugarEvento.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lugarEvento.Location = new System.Drawing.Point(506, 78);
            this.lugarEvento.Name = "lugarEvento";
            this.lugarEvento.Size = new System.Drawing.Size(83, 17);
            this.lugarEvento.TabIndex = 9;
            this.lugarEvento.Text = "Lugar Evento:";
            // 
            // descripcionEvento
            // 
            this.descripcionEvento.AutoSize = true;
            this.descripcionEvento.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descripcionEvento.Location = new System.Drawing.Point(10, 113);
            this.descripcionEvento.Name = "descripcionEvento";
            this.descripcionEvento.Size = new System.Drawing.Size(115, 17);
            this.descripcionEvento.TabIndex = 10;
            this.descripcionEvento.Text = "Descripción Evento:";
            // 
            // txtLugar
            // 
            this.txtLugar.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtLugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLugar.Location = new System.Drawing.Point(591, 70);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(248, 23);
            this.txtLugar.TabIndex = 12;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtDescripcionEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionEvento.Location = new System.Drawing.Point(127, 101);
            this.txtDescripcionEvento.Multiline = true;
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(207, 53);
            this.txtDescripcionEvento.TabIndex = 13;
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datePickerFecha.CustomFormat = "";
            this.datePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFecha.Location = new System.Drawing.Point(128, 68);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Size = new System.Drawing.Size(142, 23);
            this.datePickerFecha.TabIndex = 14;
            this.datePickerFecha.ValueChanged += new System.EventHandler(this.datePickerFecha_ValueChanged);
            // 
            // lblFechaEvento
            // 
            this.lblFechaEvento.AutoSize = true;
            this.lblFechaEvento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEvento.Location = new System.Drawing.Point(128, 70);
            this.lblFechaEvento.Name = "lblFechaEvento";
            this.lblFechaEvento.Size = new System.Drawing.Size(90, 19);
            this.lblFechaEvento.TabIndex = 15;
            this.lblFechaEvento.Text = "fechaEvento";
            this.lblFechaEvento.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(679, 256);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 40);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnCargar.IconColor = System.Drawing.Color.Blue;
            this.btnCargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargar.IconSize = 35;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(626, 99);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(176, 36);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Buscar registro";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSeleccionar.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionar.IconSize = 30;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(215, 474);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(132, 42);
            this.btnSeleccionar.TabIndex = 18;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Green;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(441, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 42);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnActualizar.IconColor = System.Drawing.Color.Blue;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 35;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(-2, 258);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 36);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(851, 528);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Álbum Empresarial de Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
    }
}
