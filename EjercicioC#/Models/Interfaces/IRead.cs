using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models.Interfaces
{
    public interface IRead<T>
    {
        List<T> GetAll();
        T getT(int id);
    }
}
