using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class DataBaseConnection
    {

        private static String connectionString = "Data Source= DESKTOP-BQRSV0H; Initial Catalog= ejemploDB;" +
          " user= sa; password= Antonieta12";
        private DataBaseConnection() { }
        public static String getConnection()
        {
            return connectionString;
        }
    }

}
