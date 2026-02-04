using CapaDatos;
using CapaEntidad;
using System.Data;


namespace CapaNegocio
{
    public class LaboratorioNegocio
    {
        LaboratorioDatos datos = new LaboratorioDatos();

        // Listar todos los laboratorios
        public DataTable Listar()
        {
            return datos.Listar();
        }

        // Guardar un nuevo laboratorio
        public void Guardar(Laboratorio lab)
        {
            datos.Insertar(lab);
        }

        // Modificar un laboratorio existente
        public bool Modificar(Laboratorio lab)
        {
            return datos.Modificar(lab);
        }

        // Eliminar un laboratorio por id
        public bool Eliminar(int id)
        {
            return datos.Eliminar(id);
        }

        
    }

}
