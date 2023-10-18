using EntityFrameworkDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB.Data.Repository
{
    public interface IAliquotsRepository : IGenericRepository<Aliquots, int>
    {

    }
    public class AliquotsRepository : GenericRepository<Aliquots, int>, IAliquotsRepository
    {
        public AliquotsRepository(DataDBContext context) : base(context)
        {
        }
    }
}
