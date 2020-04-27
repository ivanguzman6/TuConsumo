using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuConsumo.Models
{
    public class Cuenta
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        [PasswordPropertyText]
        public string Contrasena { get; set; }
    }
}