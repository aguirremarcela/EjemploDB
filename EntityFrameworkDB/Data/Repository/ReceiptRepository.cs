using EntityFrameworkDB.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Repository
{
    public interface IReceiptRepository : IGenericRepository<Receipts, int> { }
    public class ReceiptRepository : GenericRepository<Receipts, int>, IReceiptRepository
    {
        public ReceiptRepository(DataDBContext context) : base(context)
        {
        }
        //Como hago para hacer una consultar con join

        
    }
}
