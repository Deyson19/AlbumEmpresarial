using AlbumEmpresarial.Context;
using AlbumEmpresarial.Entities;
using AlbumEmpresarial.ManipulaDatos;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySqlException = MySql.Data.MySqlClient.MySqlException;

namespace AlbumEmpresarial
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext dbContext = new ApplicationDbContext();
        //Image img = Image.FromFile(@"..\Imagen\error.jpg");
        private Image imagen = global::AlbumEmpresarial.Properties.Resources.error1;
        ErrorProvider errorProvider = new ErrorProvider();

        int buscarId = 0;
        public Form1()
        {
            InitializeComponent();
            btnCargar.Enabled = false;
            btnCargar.ForeColor = Color.White;
            txtId.Enabled = false;
        }
        public Form1(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #region Limpiar los campos del formulario
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
        #endregion

        #region Evento de buscar una imagen en la base de datos.
        private void btnCargar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.ToString();

                if ((id== string.Empty))
                {
                    validarId();
                    MessageBox.Show("Debes ingresar un ID a buscar"+id);
                    txtId.Focus();
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

                        if ((data == null) || (data.Id == 0))
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
                            MessageBox.Show("Hubo un problema al recuperar la imagen.\nEl formato debe ser correcto.");
                            pbImagen.Image = imagen;

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
        #endregion

        #region Evento para seleccionar una imagen del computador.
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
        #endregion

        #region Evento para guardar los datos en la base de datos.
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
                    //Envio de los datos a la otra clase
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
                //MessageBox.Show("Hubo un error con los campos, todos deben estar completos.","Atención!");
                limpiarCampos();
            }
        }
        #endregion

        #region Estado del manipulador de fecha
        private void datePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = datePickerFecha.Value;
            
        }
        #endregion

        #region Evento para eliminar los registros de la tabla
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
        #endregion
        
        #region Evento que me permite actualizar los registros de una tabla
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
                            MessageBox.Show("Se actualiza la entrada con valor de:" + txtId.Text.ToString());
                            txtId.Text = string.Empty;
                        }
                    }
                }
            }
        }
        #endregion
        
        #region Validador de los campos para que no esten vacios
        private bool Validar()
        {
            var colorDefecto = Color.FromArgb(140, 173, 187);
           
            if (txtDescripcionImagen.Text == string.Empty)
            {
                errorProvider.SetError(txtDescripcionImagen,"Debes describir la imagen.");
                descripcion.ForeColor = Color.Red;
                txtDescripcionImagen.Focus();
                return false;
            }
            descripcion.ForeColor = colorDefecto;

            if (txtDescripcionEvento.Text == string.Empty)
            {
                errorProvider.SetError(txtDescripcionEvento,"Es necesario describir el evento.");
                descripcionEvento.ForeColor = Color.Red;
                txtDescripcionEvento.Focus();
                return false;
            }
            descripcionEvento.ForeColor = colorDefecto;

            if (txtLugar.Text == string.Empty)
            {
                errorProvider.SetError(txtLugar,"Debes indicar un lugar de la foto.");
                lugarEvento.ForeColor = Color.Red;
                txtLugar.Focus();
                return false;
            }
            lugarEvento.ForeColor = colorDefecto;

            if (pbImagen.Image == null)
            {
                errorProvider.SetError(pbImagen,"Debes seleccionar una imagen.");
                //MessageBox.Show("Debe indicar una imagen.");
                return false;
            }
            return true;
        }
        #endregion

        #region Boton para pasar a la siguiente imagen
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
                    MessageBox.Show("No se encontrado un registro en la consulta.\nIntenta con otro ID en la búsqueda.");
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
                        MessageBox.Show("Ha ocurrido un problema al recuperar la imagen.\nO no es correcto su formato.");
                        errorProvider.SetError(pbImagen, "No se pudo recuperar la image");
                        pbImagen.Image = imagen;
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
        #endregion

        #region Boton para retroceder una imagen
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
                    try
                    {
                        MemoryStream ms = new MemoryStream((byte[])data.Imagen);
                        Bitmap bm = new Bitmap(ms);
                        pbImagen.Image = bm;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un problema al recuperar la imagen.\nRevisa que el formato sea correcto.");
                        pbImagen.Image = imagen;
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

        #endregion

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtId.Text = "0";
        }

        private void txtId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validarId();
        }

        private bool validarId()
        {
            bool stado = true;
            if (txtId.Text==""||txtId.Text==null)
            {
                errorProvider.SetError(txtId, "Por favor ingresa un ID válido.");
                stado = false;
            }
            else
            {
                errorProvider.SetError(txtId, "");
            }
            return stado;
        }

        private void btnMostrarBuscarId_Click(object sender, EventArgs e)
        {
            panelOcultarId.Visible = false;
            txtId.Enabled = true;
            btnMostrarBuscarId.Visible = false;
            btnCargar.Enabled = true;

            btnGuardar.Enabled = false;
            
        }

    }
}
