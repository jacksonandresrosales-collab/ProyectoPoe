using System;

namespace CapaEntidad
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdLaboratorio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int CantidadUsuarios { get; set; }
        public string Estado { get; set; }
    }
}
