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
        public int idC {  get; set; }
        public Persons idCustomer {  get; set; }
        public string total {  get; set; }

    
        public receipts(DateTime date,int id, string total,DateTime? deleted, DateTime created, DateTime updated) : base(deleted, created, updated)
        {
            this.date = date;
            this.idC= id;
            this.total = total;
        }
        public receipts(int id, DateTime? deleted, DateTime created, DateTime updated):base(deleted, created, updated)
        {
            this.Id = id;
        }
        
    }
}
