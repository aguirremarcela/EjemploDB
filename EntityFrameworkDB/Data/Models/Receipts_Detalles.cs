using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    public class Receipts_Detalles :Model<int>
    {
        public int IdReceipts {  get; set; }
        public int IdProduct { get; set; }
        public double Unitprice {  get; set; }
        public double Quantity { get; set; }


    }
}
