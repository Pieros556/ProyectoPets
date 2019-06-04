using System.ComponentModel.DataAnnotations;

namespace ProyectoPets.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required]
        
        public Publicacion Publicacion { get; set; }
    }
}