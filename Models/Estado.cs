using System;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Web_ll.Models
{
    public class Estado
    {
        public int ID { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Nombre { get; set; }
       
    }
}