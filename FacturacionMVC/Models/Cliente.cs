using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class Cliente
    {   [Key]
        [Display(Name = "Codigo Cliente")]
        public int codigoCliente { get; set; }
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [Display(Name = "Nit")]
        public string Nit { get; set; }
        [Display(Name = "Telefono")]
        public string Telefonos { get; set; }
        [Display(Name = "Activo")]
        public char Activo { get; set; }


    }
}
