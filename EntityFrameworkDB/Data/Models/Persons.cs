using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    public  class Persons: Model<int>
    {
        [MaxLength (10,ErrorMessage ="Escriba un máximo de 10 caracteres")]
        public string? Name { get; set; }

        public virtual List<Receipts> Receipts { get; set; }

    }
}
