using System;
using System.ComponentModel.DataAnnotations;

namespace Womyads.Models
{
    public class Registro
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre está vacio")]
        [Display(Name = "Nombres")]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo E-mail está vacio ")]
        [EmailAddress(ErrorMessage="La dirección no tiene un formato válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings=false,ErrorMessage="El campo Asunto está vacio")]
        [Display(Name = "Asunto")]
        public string Asunto { get; set; }
    }
}