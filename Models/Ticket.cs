using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_ll.Models
{
    public class Ticket
    {
        public int ID { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Titulo { get; set; }
        public string Detalle { get; set; }
       
        public string PersonaReporte { get; set; }
        [Required]
       
         public int ClienteID{get;set;}

        public virtual Cliente Cliente {get;set;}
        
         public int EstadoID{get;set;}

        public virtual Estado Estado {get;set;}
    }
}