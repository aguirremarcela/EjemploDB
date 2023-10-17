using EntityFrameworkDB.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDB.Data.Repository
{

    public interface IPersonsRepository: IGenericRepository<Persons, int>
    {

    }
    public class PersonsRepository : GenericRepository<Persons, int>, IPersonsRepository
    {
        public PersonsRepository(DataDBContext context) : base(context)
        {
        }
        
    }
}
