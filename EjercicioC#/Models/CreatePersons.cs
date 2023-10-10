using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    class CreatePersons
    {

        static readonly String connection = DataBaseConnection.getConnection();
        
        public CreatePersons()
        {
            
        }

        public void Add(Persons p) 
        {
            
            
            LastIdPersons p1 = new LastIdPersons();
            int id = p1.LastId();
            String consulta = " INSERT INTO Persons (id,name,deleted,created,updated)     VALUES (@id, @name,@deleted,@created,@updated)";
            using (SqlConnection connection1 = new SqlConnection(connection))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(consulta, connection1);
                    sqlCommand.Parameters.AddWithValue("@id", id + 1);
                    sqlCommand.Parameters.AddWithValue("@name", ((object)p.Name) ?? DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@deleted", ((object)p.Deleted) ?? DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@created", p.Created);
                    sqlCommand.Parameters.AddWithValue("@updated", p.Updated);
                    connection1.Open();
                    sqlCommand.ExecuteNonQuery();// hacemos la insercion
                    connection1.Close();
                }
                catch (Exception ex)
                {
                    int cod = ex.HResult;

                }

            }
        }
    }
}
