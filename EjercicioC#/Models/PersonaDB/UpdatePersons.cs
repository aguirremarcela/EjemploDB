using EjercicioC_.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class UpdatePersons: IUpdate<Persons>
    {
        static readonly String connection1 = DataBaseConnection.getConnection();
        public UpdatePersons() { }

        public void Update(Persons p, int id)
        {
            String consulta = "UPDATE Persons SET name= @name,deleted=@deleted,created=@created,updated= @updated " +
                " WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connection1))
            {
                if (p.Name.Length <= 10)
                {
                    SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@name", ((object)p.Name) ?? DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@deleted", ((object)p.Deleted) ?? DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@created", p.Created);
                    sqlCommand.Parameters.AddWithValue("@updated", p.Updated);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();// hacemos la insercion
                    connection.Close();
                }
                else
                {
                    Console.WriteLine(" No se puede ingresar un  nombre con esa cantidad de caracteres");
                }
            }

        }
    }
}
