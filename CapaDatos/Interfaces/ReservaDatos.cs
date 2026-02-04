using System;
using System.Data;
using Npgsql;
using CapaEntidad;

namespace CapaDatos.Interfaces
{
    public class ReservaDatos : Conexion
    {
        // Insertar Reserva
        public void Insertar(Reserva res)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "INSERT INTO reserva (id_reserva, id_laboratorio, id_usuario, fecha, hora_inicio, hora_fin, cantidad_usuarios, estado) " +
                "VALUES (nextval('seq_reserva_id'), @p_lab, @p_usr, @p_fecha, @p_inicio, @p_fin, @p_cantidad, @p_estado)",
                conexion
            );

            cmd.Parameters.AddWithValue("@p_lab", res.IdLaboratorio);
            cmd.Parameters.AddWithValue("@p_usr", res.IdUsuario);
            cmd.Parameters.AddWithValue("@p_fecha", res.Fecha);
            cmd.Parameters.AddWithValue("@p_inicio", res.HoraInicio);
            cmd.Parameters.AddWithValue("@p_fin", res.HoraFin);
            cmd.Parameters.AddWithValue("@p_cantidad", res.CantidadUsuarios);
            cmd.Parameters.AddWithValue("@p_estado", res.Estado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        // Modificar Reserva
        public bool Modificar(Reserva res)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "UPDATE reserva SET id_laboratorio=@lab, id_usuario=@usr, fecha=@fecha, hora_inicio=@inicio, hora_fin=@fin, cantidad_usuarios=@cantidad, estado=@estado " +
                "WHERE id_reserva=@id",
                conexion
            );

            cmd.Parameters.AddWithValue("@lab", res.IdLaboratorio);
            cmd.Parameters.AddWithValue("@usr", res.IdUsuario);
            cmd.Parameters.AddWithValue("@fecha", res.Fecha);
            cmd.Parameters.AddWithValue("@inicio", res.HoraInicio);
            cmd.Parameters.AddWithValue("@fin", res.HoraFin);
            cmd.Parameters.AddWithValue("@cantidad", res.CantidadUsuarios);
            cmd.Parameters.AddWithValue("@estado", res.Estado);
            cmd.Parameters.AddWithValue("@id", res.IdReserva);

            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            return filas > 0;
        }

        // Cancelar Reserva (cambia estado a CANCELADA)
        public bool Cancelar(int id)
        {
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "UPDATE reserva SET estado='CANCELADA' WHERE id_reserva=@id",
                conexion
            );

            cmd.Parameters.AddWithValue("@id", id);

            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            return filas > 0;
        }

        // Consultar Reservas (listar todas)
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "SELECT id_reserva, id_laboratorio, id_usuario, fecha, hora_inicio, hora_fin, cantidad_usuarios, estado FROM reserva ORDER BY fecha, hora_inicio",
                conexion
            );

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();

            return tabla;
        }

        // Consultar Reservas por Fecha
        public DataTable ConsultarPorFecha(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            conexion.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "SELECT id_reserva, id_laboratorio, id_usuario, fecha, hora_inicio, hora_fin, cantidad_usuarios, estado " +
                "FROM reserva WHERE fecha=@fecha ORDER BY hora_inicio",
                conexion
            );

            cmd.Parameters.AddWithValue("@fecha", fecha);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();

            return tabla;
        }
        

    }
}
