using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlbumEmpresarial
{
    public class Fotos
    {
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Fecha_Evento { get; set; }
        [Required]
        public string Lugar { get; set; }
        [Required]
        public string Descripcion_Evento { get; set; }
        [Required]
        public byte[] Imagen { get; set; }

    }
}
