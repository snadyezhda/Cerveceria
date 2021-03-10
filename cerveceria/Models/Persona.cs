using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cerveceria.Models
{
    public class Persona
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, introduzca un nombre.")]
        [RegularExpression("[a-zA-Z*$]", ErrorMessage = "Por favor, introduzca un nombre válido")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Por favor, introduzca un apellido.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Por favor, introduzca un apellido valido.")]
        [RegularExpression("[a-zA-Z*$]", ErrorMessage = "Por favor, introduzca un apellido válido.")]
        public string Apellido { get; set; }

        public string Email { get; set; }
    }
}
