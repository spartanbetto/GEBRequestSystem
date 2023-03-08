using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GEBRequestSystem4.Shared
{
    public class BussinesDirection
    {
        [Key]
        public int IdBussinesDirection { get; set; }

        [Display(Name = "Nombre de la direccion de trabajo*:")]
        [Required(ErrorMessage = "Especifique el Nombre de la Direccion de trabajo.")]
        public string NameBussinesDirection { get; set; } = null!;

        public BussinesDirection()
        {

        }
    }
}