﻿using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using MySqlException = MySql.Data.MySqlClient.MySqlException;

namespace AlbumEmpresarial
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
        private List<Fotos> _fotos;
        Image img = Image.FromFile(@"..\Imagen\error.jpg");

        int buscarId = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        void limpiarCampos()
        {
            txtDescripcionEvento.Text = String.Empty;
            txtLugar.Text = String.Empty;
            lblFechaEvento.Text = String.Empty;
            lblFechaEvento.Visible = false;
            datePickerFecha.Visible = true;
            txtDescripcionImagen.Text = String.Empty;
            pbImagen.Image = null;
             
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.ToString();

                if ((id== string.Empty))
                {
                    MessageBox.Show("Debes ingresar un ID a buscar"+id);
                    txtId.Focus();
                    InitializeComponent();
                }
                else
                {
                    try
                    {
                        var data = dbContext.Fotos.Select(f => new
                        {
                            Id = f.Id,
                            Descripcion = f.Descripcion,
                            Fecha_Evento = f.Fecha_Evento,
                            Lugar = f.Lugar,
                            Descripcion_Evento = f.Descripcion_Evento,
                            Imagen = f.Imagen
                        }).FirstOrDefault(i => i.Id == Convert.ToInt32(id));

                        if ((data == null) || (data.Id == null))
                        {
                            MessageBox.Show("No se encontrado un registro en la consulta.");
                            limpiarCampos();
                            
                        }
                        else
                        {
                            txtId.Text = data.Id.ToString();
                            txtDescripcionEvento.Text = data.Descripcion_Evento.ToString();
                            txtDescripcionImagen.Text = data.Descripcion.ToString();
                            txtLugar.Text = data.Lugar.ToString();
                            datePickerFecha.Visible = false;
                            lblFechaEvento.Visible = true;
                            lblFechaEvento.Text = data.Fecha_Evento.ToString();
                        try
                        {
                            MemoryStream ms = new MemoryStream((byte[])data.Imagen);
                            Bitmap bm = new Bitmap(ms);
                            pbImagen.Image = bm;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un problema al recuperar la imagen.\nRevisa que el formato sea correcto.");
                            pbImagen.Image = img;

                        }

                        btnImgSiguiente.Visible = true;
                        buscarId = int.Parse(data.Id.ToString());
                    }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Ha ocurrido el error: " + ex);
                    }
                }
                      

        }
      
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imágenes | *.jpg; *.png";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Selecciona una imagen ";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar()==true)
            {
                MemoryStream ms = new MemoryStream();
                pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                byte[] convertirImagen = ms.ToArray();

                try
                {
                    DateTime date = datePickerFecha.Value;

                    Fotos f = new Fotos();
                    f.Descripcion = txtDescripcionImagen.Text;
                    f.Descripcion_Evento = txtDescripcionEvento.Text;
                    f.Imagen = convertirImagen;
                    f.Lugar = txtLugar.Text;
                    f.Fecha_Evento = date.ToString("yyyy-MM-dd");

                    DataAccess datos = new DataAccess();
                    datos.IngresarDatos(f);

                    limpiarCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hubo un error al tratar la imagen: " + ex.Message);
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Hubo un error con los campos, todos deben estar completos.","Atención!");
                limpiarCampos();
            }

        }

        private void datePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = datePickerFecha.Value;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.ToString();
            if (id==String.Empty || id =="0")
            {
                MessageBox.Show("Debes completar el campo Id");
                txtId.Focus();
            }
            else
            {
                DataAccess elimarRegistro = new DataAccess();
                elimarRegistro.EliminarRegistro(Convert.ToInt32(id));
                limpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.ToString();
            
            if (id == String.Empty || id == "0")
            {
                MessageBox.Show("Debes completar el campo Id");
                txtId.Focus();
                
            }
            else
            {

                if (Validar()==true)
                {
                    MemoryStream ms = new MemoryStream();
                    pbImagen.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] convertirImagen = ms.ToArray();


                    DateTime date = datePickerFecha.Value;

                    Fotos f = new Fotos();
                    f.Id = Convert.ToInt32(id);
                    f.Descripcion = txtDescripcionImagen.Text;
                    f.Descripcion_Evento = txtDescripcionEvento.Text;
                    f.Imagen = convertirImagen;
                    f.Lugar = txtLugar.Text;
                    f.Fecha_Evento = date.ToString("yyyy-MM-dd");
                    if (f == null)
                    {
                        MessageBox.Show("Debes completar todos los campos.");
                    }
                    else
                    {
                        DataAccess actualizarRegistro = new DataAccess();
                        actualizarRegistro.ActualizarRegistro(Convert.ToInt32(id), f);
                        limpiarCampos();
                        if ((txtId.Text !=null)||txtId.Text!= String.Empty)
                        {
                            MessageBox.Show("Tiene un valor de:" + txtId.Text.ToString());
                            txtId.Text = string.Empty;
                            MessageBox.Show("Test"+txtId.Text.ToString());
                        }
                    }
                }
            }
        }
        bool Validar()
        {
            if (txtDescripcionImagen.Text == string.Empty)
            {
                descripcion.ForeColor = Color.Red;
                txtDescripcionImagen.Focus();
                return false;
            }
            descripcion.ForeColor = Color.Black;

            if (txtDescripcionEvento.Text == string.Empty)
            {
                descripcionEvento.ForeColor = Color.Red;
                txtDescripcionEvento.Focus();
                return false;
            }
            descripcionEvento.ForeColor = Color.Black;

            if (txtLugar.Text == string.Empty)
            {
                lugarEvento.ForeColor = Color.Red;
                txtLugar.Focus();
                return false;
            }
            lugarEvento.ForeColor = Color.Black;

            if (pbImagen.Image == null)
            {
                MessageBox.Show("Debe indicar una imagen.");
                return false;
            }
            

            return true;
        }
        
        private void btnImgSiguiente_Click(object sender, EventArgs e)
        {
            buscarId ++;
            limpiarCampos();
            try
            {
                var data = dbContext.Fotos.Select(f => new
                {
                    Id = f.Id,
                    Descripcion = f.Descripcion,
                    Fecha_Evento = f.Fecha_Evento,
                    Lugar = f.Lugar,
                    Descripcion_Evento = f.Descripcion_Evento,
                    Imagen = f.Imagen
                }).FirstOrDefault(i => i.Id == Convert.ToInt32(buscarId));

                if ((data == null) || (data.Id == null))
                {
                    MessageBox.Show("No se encontrado un registro en la consulta.\nIntenta con otro ID.");
                    limpiarCampos();
                    InitializeComponent();
                }
                else
                {
                    txtId.Text = data.Id.ToString();
                    txtDescripcionEvento.Text = data.Descripcion_Evento.ToString();
                    txtDescripcionImagen.Text = data.Descripcion.ToString();
                    txtLugar.Text = data.Lugar.ToString();
                    datePickerFecha.Visible = false;
                    lblFechaEvento.Visible = true;
                    lblFechaEvento.Text = data.Fecha_Evento.ToString();
                    try
                    {
                        MemoryStream ms = new MemoryStream((byte[])data.Imagen);
                        Bitmap bm = new Bitmap(ms);
                        pbImagen.Image = bm;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un problema al recuperar la imagen.");
                        pbImagen.Image = img;
                    }

                    btnImgSiguiente.Visible = true;
                    if (buscarId >=1)
                    {
                        btnImgAnterior.Visible = true;
                    }
                    buscarId = int.Parse(data.Id.ToString());
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido el error: " + ex);
            }

        }

        private void btnImgAnterior_Click(object sender, EventArgs e)
        {
            buscarId--;
            limpiarCampos();
            try
            {
                var data = dbContext.Fotos.Select(f => new
                {
                    Id = f.Id,
                    Descripcion = f.Descripcion,
                    Fecha_Evento = f.Fecha_Evento,
                    Lugar = f.Lugar,
                    Descripcion_Evento = f.Descripcion_Evento,
                    Imagen = f.Imagen
                }).FirstOrDefault(i => i.Id == Convert.ToInt32(buscarId));

                if ((data == null) || (data.Id == null))
                {
                    MessageBox.Show("No se encontrado un registro en la consulta.\nIntenta con otro ID.");
                    limpiarCampos();
                    InitializeComponent();
                }
                else
                {
                    txtId.Text = data.Id.ToString();
                    txtDescripcionEvento.Text = data.Descripcion_Evento.ToString();
                    txtDescripcionImagen.Text = data.Descripcion.ToString();
                    txtLugar.Text = data.Lugar.ToString();
                    datePickerFecha.Visible = false;
                    lblFechaEvento.Visible = true;
                    lblFechaEvento.Text = data.Fecha_Evento.ToString();
                    MemoryStream ms = new MemoryStream((byte[])data.Imagen);
                    Bitmap bm = new Bitmap(ms);
                    pbImagen.Image = bm;

                    btnImgSiguiente.Visible = true;
                    if (buscarId >=1)
                    {
                        btnImgAnterior.Visible = true;
                    }
                    buscarId = int.Parse(data.Id.ToString());
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido el error: " + ex);
            }
        }
    }
}