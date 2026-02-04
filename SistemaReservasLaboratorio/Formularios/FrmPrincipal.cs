using SistemaReservasLaboratorio.Formularios;
using System;
using System.Windows.Forms;

namespace SistemaReservasLaboratorio
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            FrmLaboratorios frm = new FrmLaboratorios();
            frm.ShowDialog();
        }

        

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FrmReservas frm = new FrmReservas();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

    }
}
