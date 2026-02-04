using CapaNegocio;
using System;
using CapaEntidad;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio.Formularios
{
    public partial class FrmLaboratorios : Form
    {
        LaboratorioNegocio negocio = new LaboratorioNegocio();

        public FrmLaboratorios()
        {
            InitializeComponent();
            CargarLaboratorios();
            ConfigurarComboEstadoLaboratorio();
        }

        private void CargarLaboratorios()
        {
            dgvLaboratorios.DataSource = negocio.Listar();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            numCapacidad.Value = 1;
            cmbEstado.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void ConfigurarComboEstadoLaboratorio()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("OCUPADO");
            cmbEstado.Items.Add("DISPONIBLE");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.SelectedIndex = 1; // por defecto DISPONIBLE
        }

        // 🔎 Validación de campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del laboratorio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numCapacidad.Value <= 0)
            {
                MessageBox.Show("La capacidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado (OCUPADO o DISPONIBLE).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                Laboratorio lab = new Laboratorio
                {
                    Nombre = txtNombre.Text.Trim(),
                    Capacidad = (int)numCapacidad.Value,
                    Estado = cmbEstado.Text.Trim()
                };

                negocio.Guardar(lab);

                MessageBox.Show("Laboratorio guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLaboratorios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar laboratorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLaboratorios_Load(object sender, EventArgs e)
        {
            CargarLaboratorios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLaboratorios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un laboratorio de la tabla.");
                    return;
                }

                if (!ValidarCampos()) return;

                int id = Convert.ToInt32(
                    dgvLaboratorios.CurrentRow.Cells["id_laboratorio"].Value
                );

                Laboratorio lab = new Laboratorio
                {
                    IdLaboratorio = id,
                    Nombre = txtNombre.Text.Trim(),
                    Capacidad = (int)numCapacidad.Value,
                    Estado = cmbEstado.Text.Trim()
                };

                negocio.Modificar(lab);

                MessageBox.Show("Laboratorio modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLaboratorios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar laboratorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLaboratorios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un laboratorio para eliminar.");
                    return;
                }

                int id = Convert.ToInt32(
                    dgvLaboratorios.CurrentRow.Cells["id_laboratorio"].Value
                );

                var resp = MessageBox.Show(
                    "¿Está seguro de eliminar este laboratorio?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp == DialogResult.Yes)
                {
                    negocio.Eliminar(id);

                    MessageBox.Show("Laboratorio eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLaboratorios();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar laboratorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
