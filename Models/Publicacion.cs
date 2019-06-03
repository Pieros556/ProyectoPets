using System.ComponentModel.DataAnnotations;

namespace ProyectoPets.Models
{
    public class Publicacion
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }
        public string Foto { get; set; }

    }
}