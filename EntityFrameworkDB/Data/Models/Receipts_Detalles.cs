using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    //Receipts tiene 1 PK y dos 2FK
    public class Receipts_Detalles :Model<int>
    {
        
        public int IdReceipt {  get; set; }
        public int IdProduct { get; set; }
        public double Unitprice {  get; set; }
        public double Quantity { get; set; }
      
        [ForeignKey("IdReceipt")]
        public virtual Receipts Receipts { get; set; }
         
        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }


    }
}
