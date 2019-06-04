using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProyectoPets.ViewModels;

namespace ProyectoPets.Models
{
    public class Publicacion
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public List<Comentario> Comentario { get; set; }
        public  RegistroViewModel User { get; set; }

    }
}