
using System.Data;
using Npgsql;
using CapaEntidad;

namespace CapaDatos
{
    public class LaboratorioDatos : Conexion
    {
        //Insertar Datos
        public void Insertar(Laboratorio lab)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "INSERT INTO laboratorio (nombre, capacidad, estado) VALUES (@p_nombre, @p_capacidad, @p_estado)", 
                conexion
            );

            cmd.Parameters.AddWithValue("@p_nombre", lab.Nombre);
            cmd.Parameters.AddWithValue("@p_capacidad", lab.Capacidad);
            cmd.Parameters.AddWithValue("@p_estado", lab.Estado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Modificar Datos
        public bool Modificar(Laboratorio lab)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "UPDATE laboratorio SET nombre=@nombre, capacidad=@capacidad, Estado=@Estado WHERE id_laboratorio=@id",
                conexion
            );

            cmd.Parameters.AddWithValue("@nombre", lab.Nombre);
            cmd.Parameters.AddWithValue("@capacidad", lab.Capacidad);
            cmd.Parameters.AddWithValue("@id", lab.IdLaboratorio);
            cmd.Parameters.AddWithValue("@Estado",lab.Estado);

            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            return filas > 0;
        }
        //Eliminar Dato
        public bool Eliminar(int id)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "DELETE FROM laboratorio WHERE id_laboratorio=@id",
                conexion
            );

            cmd.Parameters.AddWithValue("@id", id);

            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            return filas > 0;
        }

        //VerTabla 
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "SELECT * FROM laboratorio" ,conexion
            );

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();

            return tabla;
        }

    }
}
