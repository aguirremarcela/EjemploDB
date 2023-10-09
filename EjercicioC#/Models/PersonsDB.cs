using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioC_.Models
{
   public class PersonsDB: IDataAccess<Persons>
    {
        //primero debo crear la conexion con la base de datos
        private  string connectionString = "Data Source= DESKTOP-BQRSV0H; Initial Catalog= ejemploDB;" +
          " user= sa; password= Antonieta12";

        ///listado de Persons
        public List<Persons> getAll()
        {
            List<Persons> persons = new List<Persons>();
            string consulta = " Select id, name, deleted, created, updated from Persons";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand= new SqlCommand(consulta, connection);
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
                    if(!reader.IsDBNull(2) && reader.IsDBNull(1))
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

        public void Add( Persons p)
        {
            //Obtengo el ultimo id, si no hay elementos en la tabla 
            int id = LastId();
            Console.WriteLine(id + "El ultimo ide");
            String consulta = " INSERT INTO Persons (id,name,deleted,created,updated)     VALUES (@id, @name,@deleted,@created,@updated)";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                
                 if (p.Name.Length <= 10) { 
                 
              
                    SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                    sqlCommand.Parameters.AddWithValue("@id", id+1);
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

        //Tiene sentido actualizar todo los campos? 
        public void Update( Persons p, int id )
        {
            String consulta = "UPDATE Persons SET name= @name,deleted=@deleted,created=@created,updated= @updated " +
                " WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
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
   
        // Metodolo Delete

        public void Delete(int Id)
        {
            String consulta = "Delete from Persons WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Persons get(int i)
        {
            throw new NotImplementedException();
        }

        public int LastId()
        {
            int index=0;
            string consulta = "SELECT  COALESCE(MAX(id),0) FROM Persons";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {  SqlCommand sqlCommand = new SqlCommand( consulta, connection);
                connection.Open();
                 index = (int)sqlCommand.ExecuteScalar();
                 connection.Close();
            } 
            
            return index;
        }
    }

}
