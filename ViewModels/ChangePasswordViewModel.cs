using System.ComponentModel.DataAnnotations;

namespace ProyectoPets.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string PasswordActual { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordNuevo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("PasswordNuevo", ErrorMessage = "Las contraseñas no coinciden")]
        public string PasswordConfirmacion { get; set; }
    }
}