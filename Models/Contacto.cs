using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Web_ll.Models
{
    public class Contacto
    {
        public int ID { get; set; }
       
        public int ClienteID{get;set;}

        public virtual Cliente Cliente {get;set;}
         [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
         [Required]
          public string Nombre { get; set; }
           [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
         [Required]
        public string Apellido_Uno { get; set; }
         [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
         [Required]
        public int Telefono { get; set; }
        public string Correo { get; set; }
        [Required]
       
        public string Puesto { get; set; }


    }
}