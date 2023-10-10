using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class DeletePersona
    {
        static readonly String connection1 = DataBaseConnection.getConnection();

        public DeletePersona() { }

        public void Delete(int Id)
        {
            String consulta = "Delete from Persons WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connection1))
            {
                SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
