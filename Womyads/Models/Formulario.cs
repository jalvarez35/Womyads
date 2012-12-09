using System;
using System.ComponentModel.DataAnnotations;

namespace Womyads.Models
{
    public class Formulario
    {
        [Required(AllowEmptyStrings=false,ErrorMessage="El Campo:Nombre, está vacio")]
        [StringLength(100)]
        [Display(Name = "Nombre(s)")]
        public string Nombre { get; set;}
        
        [Required(AllowEmptyStrings=false,ErrorMessage="El Campo:Apellido, está vacio")]
        [StringLength(100)]
        [Display(Name = "Apellido(s)")]
        public string Apellido { get; set;}

        [Display(Name="Dirección")]
        [StringLength(50)]
        public string Direccion1{get; set;}

        [Display (Name="")]
        [StringLength(50)]
        public string Direccion2{get; set;}

        [Display(Name = "")]
        [StringLength(50)]
        public string Direccion3 { get; set;}
        
        [Required(AllowEmptyStrings=false,ErrorMessage="El Campo:Cargo, está vacio")]
        [Display(Name="Cargo")]
        public string Cargo{get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo:Ciudad, está vacio")]
        [StringLength(100)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo:Teléfono, está vacio")]
        [StringLength(100)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set;}

        [Display(Name = "Estado/Provincia")]
        [StringLength(100)]
        public string Estado { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo:E-mail, está vacio")]
        [EmailAddress(ErrorMessage="La dirección ingresada no tiene un formáto válido")]
        [StringLength(100)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(100)]
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Display(Name = "¿Cómo prefiere que nos contactemos con usted?")]
        public int TContacto { get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo:Nombre de la Empresa, está vacio")]
        [StringLength(100)]
        [Display(Name = "Nombre de la Empresa")]
        public string Empresa { get; set; }

        [Url(ErrorMessage="La dirección ingresada no es válida")]
        [StringLength(100)]
        [Display(Name = "Website/URL de la Empresa")]
        public string Website { get; set; }

        [Display(Name = "Actividad Principal")]
        public string Actividad { get; set; }

        [Display(Name = "Tipo de Empresa")]
        public string Tipo { get; set; }

        [Display(Name = "Industria")]
        public string Industria { get; set; }

        [Display(Name = "Rango de Presupuesto Mensual para la Publicidad Visual(en Dolares Americanos)")]
        public float Presupuesto { get; set; }

        [Display(Name="¿En qué Productos de Microsoft Adversing está Interesado?(Por favor seleccione todas las que aplican.)")]
        public string Interes{get;set;}

        [Display(Name = "Objetivos Principales de la Compaña")]
        public string Objetivos { get; set;}

        [Display(Name = "¿Desea recibir comunicaciones de Microsoft Adversing? Por favor sellecione todas las que aplica.")]
        public string Comunicacion { get; set; }

    }
}