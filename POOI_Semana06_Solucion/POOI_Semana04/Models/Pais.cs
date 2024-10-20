using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POOI_Semana04.Models
{
    public class Pais
    {
        [DisplayName("Codigo Pais")]
        [Required(ErrorMessage ="El campo es obligatorio")]
        [MinLength(2, ErrorMessage ="Minimo debe ser 2 caracteres")]
        [MaxLength(2, ErrorMessage ="Maximo debe ser 2 caracteres")]
        public string country_id { get; set; }

        [DisplayName("Nombre")]
        [MaxLength(40, ErrorMessage ="Maximo debe ser 40 caracteres")]
        [Required]
        public string country_name { get; set;}

        [DisplayName("Region")]
        public int region_id { get; set; }

        public Pais()
        {
            this.country_id = "";
            this.country_name = "";
            this.region_id = 0;
        }

        public Pais(string country_id, string country_name, int region_id)
        {
            this.country_id = country_id;
            this.country_name = country_name;
            this.region_id = region_id;
        }
    }
}