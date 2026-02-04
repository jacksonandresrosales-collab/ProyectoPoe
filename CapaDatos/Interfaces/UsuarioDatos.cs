using System.Data;
using Npgsql;
using CapaEntidad;

namespace CapaDatos
{
    public class UsuarioDatos : Conexion
    {
        // Registrar
        public void Registrar(Usuario usr)
        {
            try
            {
                conexion.Open();

                using (var cmd = new NpgsqlCommand(
                   "INSERT INTO usuario (cedula, nombre, apellido, correo, estado) VALUES (@cedula, @nombre, @apellido, @correo, @estado)",
                    conexion))
                {
                    cmd.Parameters.AddWithValue("@cedula", usr.Id);
                    cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usr.Apellido);
                    cmd.Parameters.AddWithValue("@correo", usr.Correo);
                    cmd.Parameters.AddWithValue("@estado", usr.Estado ?? "ACTIVO");

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        // Modificar
        public bool Modificar(Usuario usr)
        {
            try
            {
                conexion.Open();

                using (var cmd = new NpgsqlCommand(
                    "UPDATE usuario SET nombre=@nombre, apellido=@apellido, correo=@correo, estado=@estado WHERE cedula=@cedula",
                    conexion))
                {
                    cmd.Parameters.AddWithValue("@cedula", usr.Id);
                    cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usr.Apellido);
                    cmd.Parameters.AddWithValue("@correo", usr.Correo);
                    cmd.Parameters.AddWithValue("@estado", usr.Estado ?? "ACTIVO");

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        // Dar de baja Usuario
        public bool DarDeBaja(string cedula)
        {
            try
            {
                conexion.Open();

                using (var cmd = new NpgsqlCommand(
                    "UPDATE usuario SET estado='INACTIVO' WHERE cedula=@cedula",
                    conexion))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        // Consultar Usuarios
        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();

            try
            {
                conexion.Open();

                string sql = "SELECT estado, id_usuario, cedula, nombre, apellido, correo " +
                             "FROM usuario ORDER BY cedula ASC";

                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return tabla;
        }

    }
}
