using CapaDatos.Interfaces;
using CapaEntidad;
using System;
using System.Data;

namespace CapaNegocio
{
    public class ReservaNegocio
    {
        ReservaDatos datos = new ReservaDatos();

        // Listar todas las reservas
        public DataTable Listar()
        {
            return datos.Listar();
        }

        // Guardar una nueva reserva
        public void Guardar(Reserva res)
        {
            datos.Insertar(res);
        }

        // Modificar una reserva existente
        public bool Modificar(Reserva res)
        {
            return datos.Modificar(res);
        }

        // Cancelar una reserva por id
        public bool Cancelar(int id)
        {
            return datos.Cancelar(id);
        }


        // Consultar reservas por fecha
        public DataTable ConsultarPorFecha(DateTime fecha)
        {
            return datos.ConsultarPorFecha(fecha);
        }
    }
}
