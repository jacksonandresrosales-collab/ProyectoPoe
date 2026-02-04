using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace SistemaReservasLaboratorio.Formularios
{
    public partial class FrmUsuario : Form
    {
        public UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            ConfigurarComboEstado();
        }

        // 🔎 Método de validación de campos vacíos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("El campo Cédula no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El campo Correo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbEstado.Text))
            {
                MessageBox.Show("Debe seleccionar un Estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                DataTable usuarios = usuarioNegocio.Consultar();
                foreach (DataRow row in usuarios.Rows)
                {
                    if (row["cedula"].ToString() == txtId.Text.Trim())
                    {
                        MessageBox.Show("Usuario ya registrado con esa cédula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Usuario usuario = new Usuario
                {
                    Id = txtId.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Estado = cmbEstado.Text.Trim(),
                };

                usuarioNegocio.Registrar(usuario);
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = usuarioNegocio.Consultar();
        }

        private void ConfigurarComboEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtId.Text.Trim();

                if (string.IsNullOrEmpty(cedula))
                {
                    MessageBox.Show("Ingrese una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (usuarioNegocio.DarDeBaja(cedula))
                {
                    MessageBox.Show("Usuario dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario con esa cédula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                Usuario usuario = new Usuario
                {
                    Id = txtId.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Estado = cmbEstado.Text.Trim()
                };

                if (usuarioNegocio.Modificar(usuario))
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario con esa cédula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = null; // limpiar
                dgvUsuarios.DataSource = usuarioNegocio.Consultar(); // ahora solo por cédula
                MessageBox.Show("Usuarios consultados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
