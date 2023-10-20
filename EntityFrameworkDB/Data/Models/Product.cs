using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Models
{
    //imaginemos que un producto puede tener una Alicuota
    //y que una Alicuota puede tener varios productos
    public class Product : Model<int>
    {
        public string Name { get; set; }
        public  string? Image {  get; set; }
        public int Id_Aliquot {  get; set; }
        public decimal Price {  get; set; }
        
        [ForeignKey("Id_Aliquot")]
        public virtual Aliquots Aliquots { get; set; }

        public virtual List<Receipts_Detalles> Receipts { get; set; }

        public Product() {
            Receipts = new List<Receipts_Detalles>();
        }
    }
}
