using EjercicioC_.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    class CreatePersons: ICreate<Persons>
    {

        static readonly String connection = DataBaseConnection.getConnection();
        
        public CreatePersons()
        {
            
        }

        public void add(Persons p) 
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
                    int row =sqlCommand.ExecuteNonQuery();// hacemos la insercion
                    if(row > 0)
                    {
                        
                        ManejoSqlCod.GetMessage(1);
                    }
                    connection1.Close();
                }
                catch (SqlException ex)
                {
                    ManejoSqlCod.GetMessage(ex.HResult);
                }
               

        }
        }
    }
}
