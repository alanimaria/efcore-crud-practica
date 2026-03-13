// TODO: Agrega [Required], [StringLength], [Display] apropiados
// TODO: Agrega [Required], [EmailAddress], [Display]
// TODO: Agrega [Phone] y que NO sea obligatorio
// TODO: El cliente debe ser mayor de 18 años
// Pista: usa [Range] con DateTime o implementa IValidatableObject

using System.ComponentModel.DataAnnotations;

namespace ProyectoWebScrub.Models
{
    public class Cliente
    {
        public int Id { 
            get; set; 
        }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { 
            get; set; 
        } = "";

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo inválido")]
        public string Email { 
            get; set; 
        } = "";

        public string? Telefono { 
            get; set; 
        }

        public DateOnly FechaNacimiento { 
            get; set; }
    }
}
