using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class Producto
    {
        [Key]
        [Display(Name = "Codigo Producto")]
        public int CodigoProducto { get; set; }
        [Required(ErrorMessage = "El campo No puede ir vacio")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo No puede ir vacio")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo No puede ir vacio")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El campo No puede ir vacio")]
        [Display(Name = "Costo")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "El campo No puede ir vacio")]
        [Display(Name = "Existencia")]
        public int Existencia { get; set; }
        [Display(Name = "Activo")]
        public char Activo { get; set; }

    }
}
