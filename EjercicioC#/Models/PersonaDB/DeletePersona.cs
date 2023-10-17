using EjercicioC_.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class DeletePersona:IDelete
    {
        static readonly String connection1 = DataBaseConnection.getConnection();

        public DeletePersona() { }

        public void Delete(int Id)

        {
            String consulta = "Delete from Persons WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connection1))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                    sqlCommand.Parameters.AddWithValue("@id", Id);
                    connection.Open();
                    int row=sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    ManejoSqlCod.GetMessage(row);

                }
                catch (SqlException ex)
                {
                    ManejoSqlCod.GetMessage(ex.HResult);
                }
            }
        }
    }
}
