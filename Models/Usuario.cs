using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_ll.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Nombre { get; set; }
        public string Apellido_Uno { get; set; }
        [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
         [Required]
        public string User { get; set; }
        public int? Telefono { get; set; }
        public string Correo { get; set; }
        [Required]
        public string Contrasenna { get; set; }
        public string Puesto { get; set; }
    }
}