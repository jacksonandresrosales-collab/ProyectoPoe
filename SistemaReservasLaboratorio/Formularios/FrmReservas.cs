using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Formularios
{
    public partial class FrmReservas : Form
    {
        ReservaNegocio reservaNegocio = new ReservaNegocio();

        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
            CargarUsuarios();
            CargarLaboratorios();
            ConfigurarComboEstado();
        }

        private void ConfigurarComboEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("ACTIVA");
            cmbEstado.Items.Add("CANCELADA");
            cmbEstado.Items.Add("FINALIZADA");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.SelectedIndex = 0;
        }

        private void CargarLaboratorios()
        {
            LaboratorioNegocio labNegocio = new LaboratorioNegocio();
            cmbLaboratorio.DataSource = labNegocio.Listar();
            cmbLaboratorio.DisplayMember = "nombre";
            cmbLaboratorio.ValueMember = "id_laboratorio";
            cmbLaboratorio.SelectedIndex = -1;
        }

        private void CargarUsuarios()
        {
            UsuarioNegocio userNegocio = new UsuarioNegocio();
            cmbUsuario.DataSource = userNegocio.Consultar();
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "id_usuario";
            cmbUsuario.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            txtIdReserva.Clear();
            cmbLaboratorio.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now.AddHours(1);
            txtCantidadUsuarios.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarReservas()
        {
            dgvReservas.DataSource = reservaNegocio.Listar();
        }

        // 🔎 Validación de campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdReserva.Text))
            {
                MessageBox.Show("El campo ID de Reserva no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbLaboratorio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un laboratorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadUsuarios.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtCantidadUsuarios.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese un número válido en Cantidad de Usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpHoraFin.Value <= dtpHoraInicio.Value)
            {
                MessageBox.Show("La hora de fin debe ser mayor que la hora de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                Reserva res = new Reserva
                {
                    IdLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue),
                    IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue),
                    Fecha = dtpFecha.Value.Date,
                    HoraInicio = dtpHoraInicio.Value.TimeOfDay,
                    HoraFin = dtpHoraFin.Value.TimeOfDay,
                    CantidadUsuarios = Convert.ToInt32(txtCantidadUsuarios.Text),
                    Estado = cmbEstado.Text.Trim()
                };

                reservaNegocio.Guardar(res);
                MessageBox.Show("Reserva registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarReservas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                Reserva res = new Reserva
                {
                    IdLaboratorio = Convert.ToInt32(cmbLaboratorio.SelectedValue),
                    IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue),
                    Fecha = dtpFecha.Value.Date,
                    HoraInicio = dtpHoraInicio.Value.TimeOfDay,
                    HoraFin = dtpHoraFin.Value.TimeOfDay,
                    CantidadUsuarios = Convert.ToInt32(txtCantidadUsuarios.Text),
                    Estado = cmbEstado.Text.Trim()
                };

                if (reservaNegocio.Modificar(res))
                {
                    MessageBox.Show("Reserva modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReservas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la reserva con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReservas.DataSource = reservaNegocio.ConsultarPorFecha(dtpFecha.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdReserva.Text))
                {
                    MessageBox.Show("Debe ingresar un ID de reserva válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = Convert.ToInt32(txtIdReserva.Text);
                if (reservaNegocio.Cancelar(id))
                {
                    MessageBox.Show("Reserva cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReservas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la reserva con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
}
