using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkDB.Data.Models
{
    public abstract class Model<TId>
    {
        [Key]
        public TId Id { get; set; }
        public DateTime? Deleted {  get; set; }
        
        [Required(ErrorMessage ="Seleccione la fecha de creacion")]
        [DataType(DataType.DateTime, ErrorMessage ="Seleccione una fecha valida")]
        public DateTime Created {  get; set; }
        [Required(ErrorMessage = "Seleccione la fecha de actualizacion")]
        [DataType(DataType.DateTime)]
        public DateTime Updated { get; set; }
    }
}
