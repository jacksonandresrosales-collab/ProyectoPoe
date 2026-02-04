namespace SistemaReservasLaboratorio.Formularios
{
    partial class FrmReservas
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
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadUsuarios = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.grpAcciones2 = new System.Windows.Forms.GroupBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpInformacion.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.grpAcciones2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdReserva.Location = new System.Drawing.Point(114, 36);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(120, 26);
            this.txtIdReserva.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laboratorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad Usuarios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estado";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(341, 33);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(202, 28);
            this.cmbLaboratorio.TabIndex = 9;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(114, 73);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(196, 28);
            this.cmbUsuario.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(114, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 11;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(407, 84);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(136, 26);
            this.dtpHoraInicio.TabIndex = 12;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(407, 126);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(136, 26);
            this.dtpHoraFin.TabIndex = 13;
            // 
            // txtCantidadUsuarios
            // 
            this.txtCantidadUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadUsuarios.Location = new System.Drawing.Point(214, 169);
            this.txtCantidadUsuarios.Name = "txtCantidadUsuarios";
            this.txtCantidadUsuarios.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadUsuarios.TabIndex = 14;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(422, 171);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 15;
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.SkyBlue;
            this.grpInformacion.Controls.Add(this.label1);
            this.grpInformacion.Controls.Add(this.cmbEstado);
            this.grpInformacion.Controls.Add(this.txtIdReserva);
            this.grpInformacion.Controls.Add(this.txtCantidadUsuarios);
            this.grpInformacion.Controls.Add(this.label2);
            this.grpInformacion.Controls.Add(this.dtpHoraFin);
            this.grpInformacion.Controls.Add(this.dtpHoraInicio);
            this.grpInformacion.Controls.Add(this.cmbLaboratorio);
            this.grpInformacion.Controls.Add(this.label8);
            this.grpInformacion.Controls.Add(this.cmbUsuario);
            this.grpInformacion.Controls.Add(this.label7);
            this.grpInformacion.Controls.Add(this.dtpFecha);
            this.grpInformacion.Controls.Add(this.label6);
            this.grpInformacion.Controls.Add(this.label3);
            this.grpInformacion.Controls.Add(this.label5);
            this.grpInformacion.Controls.Add(this.label4);
            this.grpInformacion.Location = new System.Drawing.Point(13, 39);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(563, 207);
            this.grpInformacion.TabIndex = 16;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Informacion";
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.SkyBlue;
            this.grpAcciones.Controls.Add(this.btnLimpiar);
            this.grpAcciones.Controls.Add(this.btnConsultar);
            this.grpAcciones.Controls.Add(this.btnModificar);
            this.grpAcciones.Location = new System.Drawing.Point(582, 39);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(192, 289);
            this.grpAcciones.TabIndex = 17;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(28, 201);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 55);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(28, 114);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(142, 55);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(28, 33);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(142, 55);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(91, 14);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(142, 55);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(323, 14);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(142, 51);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // grpAcciones2
            // 
            this.grpAcciones2.BackColor = System.Drawing.Color.SkyBlue;
            this.grpAcciones2.Controls.Add(this.BtnCancelar);
            this.grpAcciones2.Controls.Add(this.btnRegistrar);
            this.grpAcciones2.Location = new System.Drawing.Point(14, 253);
            this.grpAcciones2.Name = "grpAcciones2";
            this.grpAcciones2.Size = new System.Drawing.Size(562, 75);
            this.grpAcciones2.TabIndex = 18;
            this.grpAcciones2.TabStop = false;
            this.grpAcciones2.Text = "Acciones";
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(13, 336);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 62;
            this.dgvReservas.RowTemplate.Height = 28;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(761, 161);
            this.dgvReservas.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(244, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(332, 20);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "MODULO DE RESERVAS Y PRESTAMOS";
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 509);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.grpAcciones2);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Reservas de Laboratorios";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.grpAcciones2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.TextBox txtCantidadUsuarios;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox grpAcciones2;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblTitulo;
    }
}