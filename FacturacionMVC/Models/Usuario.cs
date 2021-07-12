using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Codigo Usuario")]
        public int idUsuario { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "Usuario")]
        public string NUsuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }
        [Display(Name = "Activo")]
        public char Activo { get; set; }




    }
}
