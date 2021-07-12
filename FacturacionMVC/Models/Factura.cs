using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.Models
{
    public class Factura
    {
        [Key]
        [Display(Name = "Numero Factura")]
        public int NumeroFactura { get; set; }

        [Required(ErrorMessage = "El campo fecha no puede ir vacío")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Display(Name = "Total Factura")]
        public decimal TotalFactura { get; set; }
        [Display(Name = "Anulada")]
        public char Anulada { get; set; }

        [Display(Name = "Cliente")]
         
        public int? codigoCliente { get; set; }
        [ForeignKey("codigoCliente")]
        public virtual Cliente cliente { get; set; }
    }
}
