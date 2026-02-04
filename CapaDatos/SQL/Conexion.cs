using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        protected NpgsqlConnection conexion;

        public Conexion()
        {
            conexion = new NpgsqlConnection(
                "Host=localhost;" +
                "Port=5432;" +
                "Username=postgres;" +
                "Password=1234;" +
                "Database=reservasdb;"
            );
        }

        public void ProbarConexion()
        {
            try
            {
                conexion.Open();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }

    }
}

