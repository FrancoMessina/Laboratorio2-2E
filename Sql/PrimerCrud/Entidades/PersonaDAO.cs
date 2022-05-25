using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public class PersonaDAO
    {
        private static string cadenaConexion;

        static PersonaDAO()
        {
            PersonaDAO.cadenaConexion = "Server=.;Database=Personas;Trusted_Connection=True;";
        }
        public static List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            try
            {
                string query = "SELECT * FROM persona";
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        Persona persona = new Persona(id, nombre, apellido);
                        lista.Add(persona);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
        public static void Guardar(Persona persona)
        {

            SqlConnection conexion = null;
            string query = "Insert into persona (nombre,apellido) values(@nombre, @apellido)";
            try
            {
               
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                cmd.ExecuteNonQuery();
                    
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public static Persona LeerPorId(int id)
        {
            Persona persona = null;
            string query = "Select * from persona where id = @id";
            try
            {
                using(SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("id", id);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int idRecibido = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        persona = new Persona(idRecibido, nombre, apellido);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return persona;
        }
        public static void Modificar(int id, Persona persona)
        {
            string query = "update persona set nombre=@nombre, apellido=@apellido where id = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                    cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Borrar(int id)
        {
            string query = "delete from persona where id = @id";
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("id", id);
                conexion.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
