using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimerTurno.Models
{
    public class Usuario : Persona
    {
        [Key]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Debe Ingresar un Usuario")]
        [Display(Name = "Usuario")]
        public string UsuarioNombre { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Debe ingresar un Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}