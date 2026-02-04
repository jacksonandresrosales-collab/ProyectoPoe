    using CapaDatos;
    using CapaEntidad;
    using System;
    using System.Data;

    namespace CapaNegocio
    {
        public class UsuarioNegocio
        {
            UsuarioDatos datos = new UsuarioDatos();

            // Consultar todos los usuarios
            public DataTable Consultar()
            {
                return datos.Consultar();
        }

            // Registrar un nuevo usuario
            public void Registrar(Usuario usr)
            {
                datos.Registrar(usr);
            }

            // Modificar un usuario existente
            public bool Modificar(Usuario usr)
            {
                return datos.Modificar(usr);
            }

            // Dar de baja a un usuario por id
            public bool DarDeBaja(string cedula)
            {
                return datos.DarDeBaja(cedula);
            }
        }
    }
