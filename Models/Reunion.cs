using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Web_ll.Models
{
    public class Reunion
    {
        public int ID { get; set; }
           
        [ForeignKey("Cliente")]
        public int? Id_Cliente{get;set;}
        [StringLength(50, ErrorMessage = "No puede ser mayor a 50 Caracteres.")]
        [Required]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }   
        [Required]
        
        public Boolean Virtual { get; set; }
        
        [Required]
        [ForeignKey("Usuario")]
        public int Id_Usuario{get;set;}
        


    }
}