using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
     class receipts: Registros
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Persons idCustomer {  get; set; }
        public int total {  get; set; }
        public receipts(DateTime deleted, DateTime created, DateTime updated) : base(deleted, created, updated)
        {

        }
    }
}
