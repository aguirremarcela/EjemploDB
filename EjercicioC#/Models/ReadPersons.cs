using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC_.Models
{
    public class ReadPersons
    {
        static readonly String connection1 = DataBaseConnection.getConnection();
        public ReadPersons() { }

        public List<Persons> GetAll()
        {
            List<Persons> persons = new List<Persons>();
            string consulta = " Select id, name, deleted, created, updated from Persons";
            using (SqlConnection connection = new SqlConnection(connection1))
            {
                SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    //debo manejar exceptiones porque el delete no me puede 
                    ;
                    if (!reader.IsDBNull(2) && !reader.IsDBNull(1))
                    {
                        Persons p1 = new Persons(reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetDateTime(4));
                        p1.Id = Convert.ToInt32(reader.GetInt32(0));
                        persons.Add(p1);
                    }
                    if (!reader.IsDBNull(2) && reader.IsDBNull(1))
                    {
                        Persons p1 = new Persons(null, reader.GetDateTime(2), reader.GetDateTime(3), reader.GetDateTime(4));
                        p1.Id = Convert.ToInt32(reader.GetInt32(0));
                        persons.Add(p1);
                    }
                    if (reader.IsDBNull(2) && !reader.IsDBNull(1))
                    {
                        Persons p1 = new Persons(reader.GetString(1), null, reader.GetDateTime(3), reader.GetDateTime(4));
                        p1.Id = Convert.ToInt32(reader.GetInt32(0));
                        persons.Add(p1);

                    }
                    else
                    {
                        //Manejar el caso en el que el valor es nulo (por ejemplo, asignar un valor predeterminado o realizar alguna acción específica)
                        Persons p1 = new Persons(null, null, reader.GetDateTime(3), reader.GetDateTime(4));
                        p1.Id = Convert.ToInt32(reader.GetInt32(0));
                        persons.Add(p1);
                    }
                }
                reader.Close();
                connection.Close();
            }
            return persons;
        }
    }
}
