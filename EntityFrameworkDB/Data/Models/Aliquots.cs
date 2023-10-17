using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    public  class Aliquots:Model<int>
    {
        [Required(ErrorMessage ="Ingrese el nombre de la alicuota")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Porcentaje %")]
        [Range(0,100)]
        public decimal Percentaje {  get; set; }
    }
}
