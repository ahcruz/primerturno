using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimerTurno.Models
{
    public class Persona
    {
        public enum Tipo { Periodista, Administrador, Camarografo, Sonidista }
        [Key]
        [Required(ErrorMessage = "Te faltó el DNI")]
        [Display(Name = "DNI")]        
        public int DNI { get; set; }
        [Required(ErrorMessage="Te faltó el Apellido")]
        [DataType(DataType.Text)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }        
        [Required(ErrorMessage = "Te faltó el Nombre")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Te faltó el Tipo")]
        [Display(Name = "Tipo")]
        public Tipo TipoT { get; set; }
    }
}