using EjercicioC_.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models.ReceiptsDB
{
    class CreateReceipts : ICreate<receipts>
    {
        static readonly String connection = DataBaseConnection.getConnection();
        public void add(receipts rec)
        {

            LastIdReceipts p1 = new LastIdReceipts();
            ReadPersons readPersons = new ReadPersons();
            Persons pq = readPersons.getT(rec.idC);//si encuentra una Persons con ese id me lo va a insetar
            int id = p1.LastId();
            if(pq!=null)
            {
                String consulta = " INSERT INTO receipts (id,date,idcustomer,total,deleted,created,updated)     VALUES (@id, @date,@idcustomer,@total,@deleted,@created,@updated)";
                using (SqlConnection connection1 = new SqlConnection(connection))
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(consulta, connection1);
                        sqlCommand.Parameters.AddWithValue("@id", id + 1);
                        sqlCommand.Parameters.AddWithValue("@date", rec.date);
                        sqlCommand.Parameters.AddWithValue("@idcustomer", rec.idC);
                        sqlCommand.Parameters.AddWithValue("@total", rec.total);
                        sqlCommand.Parameters.AddWithValue("@deleted", ((object)rec.Deleted) ?? DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@created", rec.Created);
                        sqlCommand.Parameters.AddWithValue("@updated", rec.Updated);
                        connection1.Open();
                        sqlCommand.ExecuteNonQuery();
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
}
