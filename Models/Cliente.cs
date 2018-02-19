using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_ll.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
         [Required]
        public string Nombre { get; set; }
        [Required]
        public string CedulaJuridica { get; set; }
        public string PaginaWeb { get; set; }
         [StringLength(150, ErrorMessage = "No puede ser mayor a 150 Caracteres.")]
         [Required]
        public  string DireccionFisica  { get; set; }
        public int? telefono { get; set; }
        [Required]
        public string Sector { get; set; }
    }
}