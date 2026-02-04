namespace SistemaReservasLaboratorio.Formularios
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpInformacion.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(25, 33);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(30, 20);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(164, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(262, 26);
            this.txtId.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(25, 71);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(25, 105);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(65, 20);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(25, 140);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(57, 20);
            this.LblCorreo.TabIndex = 4;
            this.LblCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(164, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(164, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(164, 137);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(262, 26);
            this.txtCorreo.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(25, 51);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 54);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.SkyBlue;
            this.grpInformacion.Controls.Add(this.cmbEstado);
            this.grpInformacion.Controls.Add(this.lblEstado);
            this.grpInformacion.Controls.Add(this.LblId);
            this.grpInformacion.Controls.Add(this.txtId);
            this.grpInformacion.Controls.Add(this.LblNombre);
            this.grpInformacion.Controls.Add(this.txtNombre);
            this.grpInformacion.Controls.Add(this.LblApellido);
            this.grpInformacion.Controls.Add(this.txtCorreo);
            this.grpInformacion.Controls.Add(this.txtApellido);
            this.grpInformacion.Controls.Add(this.LblCorreo);
            this.grpInformacion.Location = new System.Drawing.Point(12, 32);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpInformacion.Size = new System.Drawing.Size(463, 217);
            this.grpInformacion.TabIndex = 12;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(164, 173);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(29, 176);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.SkyBlue;
            this.grpAcciones.Controls.Add(this.btnConsultar);
            this.grpAcciones.Controls.Add(this.btnDarDeBaja);
            this.grpAcciones.Controls.Add(this.btnModificar);
            this.grpAcciones.Controls.Add(this.btnRegistrar);
            this.grpAcciones.Location = new System.Drawing.Point(500, 32);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(228, 217);
            this.grpAcciones.TabIndex = 13;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(121, 123);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 54);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Location = new System.Drawing.Point(25, 123);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(90, 54);
            this.btnDarDeBaja.TabIndex = 10;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(121, 51);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 54);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 255);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(716, 192);
            this.dgvUsuarios.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(271, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 20);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "MODULO DE USUARIOS";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 463);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblTitulo;
    }
}