using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    public class Receipts :Model<int>
    {
        public DateTime? Date { get; set; }
        public int IdCustomer {  get; set; }
        [MaxLength(10)]
        public string? Total { get; set; }

        [ForeignKey("IdCustomer")]// un recibo pertenece a una persona
        
       public virtual Persons Persona { get; set; }//tiene que ser vitual para que no sea un campo de la tabla
        public virtual List<Receipts_Detalles> Detalles { get; set;}

        public Receipts()
        {
            Detalles= new List<Receipts_Detalles>();
        }
    
    }
}
