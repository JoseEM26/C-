using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POOI_T3_DanielAlexanderDeLaCruzBriceño.Models
{
    public class Empleados
    {
        [Required]
        public int IdEmpleado { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string DNI { get; set; }
        [Required]
        public string Email { get; set; }
    }
}