using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class Registros
    {
        public DateTime? Deleted { get; set; } = null;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Registros( DateTime? deleted, DateTime created, DateTime update) 
        {
            this.Deleted = deleted;
            this.Created = created;
            this.Updated = update;

        }

    }
}
