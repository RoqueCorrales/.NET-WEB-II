using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_Web_ll.Models
{
    public class Sector
    {
        public int ID { get; set; }
       [Required]
        public string Nombre { get; set; }
          
    }
}