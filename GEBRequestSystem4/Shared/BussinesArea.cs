using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GEBRequestSystem4.Shared
{
    public class BussinesArea
    {
        [Key]
        public int IdBussinesArea { get; set; }

        public BussinesDirection BussinesDirection { get; set; } = null!;
        [Display(Name = "Dirección de trabajo*:")]
        [Required(ErrorMessage = "Especifique el Dirección de trabajo.")]
        public int IdBussinesDirection { get; set; }

        [Display(Name = "Area de trabajo*:")]
        [Required(ErrorMessage = "Especifique el Area de trabajo.")]
        public string NameBussinesArea { get; set; } = null!;

        public BussinesArea()
        {

        }
    }
}
