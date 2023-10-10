using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
     class LastIdPersons
    {
        static readonly String connection1 = DataBaseConnection.getConnection();
        public int LastId()
        {
            int index = 0;
            string consulta = "SELECT  COALESCE(MAX(id),0) FROM Persons";
            using (SqlConnection connection = new SqlConnection(connection1))
            {
                SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                connection.Open();
                index = (int)sqlCommand.ExecuteScalar();
                connection.Close();
            }

            return index;
        }
    }
}
