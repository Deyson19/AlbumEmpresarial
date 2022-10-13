using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumEmpresarial
{
    public class DataAccess
    {

       private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public DataAccess(ApplicationDbContext context)
        {
            _context = context;
        }
        public DataAccess()
        {
        }
        //public async Task<List<Fotos>> TraerRegistro(int id)
        //{
        //    List<Fotos> fotos = new List<Fotos>();
        //    try
        //    {
        //        var data = await _context.Fotos.Select(f => new
        //        {
        //            Id = f.Id,
        //            Descripcion = f.Descripcion,
        //            Fecha_Evento = f.Fecha_Evento,
        //            Lugar = f.Lugar,
        //            Descripcion_Evento = f.Descripcion_Evento,
        //            Imagen = f.Imagen
        //        }).FirstOrDefaultAsync(i => i.Id == Convert.ToInt32(id));

        //        fotos.Add(new Fotos
        //        {
        //            Id = data.Id,
        //            Descripcion = data.Descripcion,
        //            Fecha_Evento = data.Fecha_Evento,
        //            Lugar = data.Lugar,
        //            Descripcion_Evento = data.Descripcion_Evento,
        //            Imagen = data.Imagen
        //        });
        //        if (data == null)
        //        {
        //            MessageBox.Show("No se encontraron resultados.");
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No encontramos resultados.");
        //    }
        //    return fotos;
            
        //}
        public void EliminarRegistro(int id)
        {
            try
            {
                var eliminarFoto = _context.Fotos.FirstOrDefault(d => d.Id == id);
                if (eliminarFoto==null)
                {
                    MessageBox.Show("No se encontrado un registro. " +
                        "\nIntenta con otro ID");
                }
                _context.Fotos.Remove(eliminarFoto);
                _context.SaveChanges();
                MessageBox.Show("Imagen y los datos se han borrado");
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
            }
            MessageBox.Show("Eliminamos un registro");
        }

        public void IngresarDatos(Fotos f)
        {
            try
            {
                _context.Fotos.Add(f);
                _context.SaveChanges();
                MessageBox.Show("Imagen guardada");
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString(); 
            }
        }

        public void ActualizarRegistro(int id, Fotos f)
        {
            var buscarRegistro = _context.Fotos.FirstOrDefault(d => d.Id == id);
            try
            {
                if (!(buscarRegistro is null))
                {
                    if (id == buscarRegistro.Id)
                    {
                        buscarRegistro.Descripcion = f.Descripcion;
                        buscarRegistro.Lugar = f.Lugar;
                        buscarRegistro.Descripcion_Evento = f.Descripcion_Evento;
                        buscarRegistro.Imagen = f.Imagen;
                        buscarRegistro.Fecha_Evento = f.Fecha_Evento;

                        _context.Fotos.Update(buscarRegistro);
                        _context.SaveChangesAsync();

                        MessageBox.Show("Actualizamos el registro:"+buscarRegistro);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar."+ex);
            }
            MessageBox.Show("Se ha actualizado un registro.");
        }
    }
}
