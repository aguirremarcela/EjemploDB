using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    internal interface IDataAccess<T>
    {
       
        List<T> getAll();
        T get(int i);
        void Add(T t);
        void Update(T t, int id);
        void Delete(int i);
        int LastId();
    }

}
