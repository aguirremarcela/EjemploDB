using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public static class ManejoSqlCod
    {
       

        public static void GetMessage(int errorCode)
        {
            switch (errorCode)
            {
                case -2146232060: 
                    Console.WriteLine("No se puede ingresar el registro porque hay un trancaminento en una de las columnas");
                    break;
                case -2147467261: 
                    Console.WriteLine("No se puede leer valores null");
                    break;
                case 1: 
                    Console.WriteLine("Operacion exitosa");
                    break;
                case 0:
                    Console.WriteLine("No se encontro el id del registro a eliminar");
                    break;
                default:
                    Console.WriteLine("Se produjo una excepción con código no manejado: " + errorCode);
                    break;
            }

        }
    }
}
