namespace SistemaReservasLaboratorio.Formularios
{
    partial class FrmLaboratorios
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.LblCapacidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(46, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE LABORATORIOS";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.SkyBlue;
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.cmbEstado);
            this.grpDatos.Controls.Add(this.numCapacidad);
            this.grpDatos.Controls.Add(this.LblCapacidad);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.LblNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 56);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(497, 162);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Laboratorio ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(349, 93);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 4;
            // 
            // numCapacidad
            // 
            this.numCapacidad.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.numCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCapacidad.Location = new System.Drawing.Point(125, 95);
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 26);
            this.numCapacidad.TabIndex = 3;
            this.numCapacidad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LblCapacidad
            // 
            this.LblCapacidad.AutoSize = true;
            this.LblCapacidad.Location = new System.Drawing.Point(24, 95);
            this.LblCapacidad.Name = "LblCapacidad";
            this.LblCapacidad.Size = new System.Drawing.Size(85, 20);
            this.LblCapacidad.TabIndex = 2;
            this.LblCapacidad.Text = "Capacidad";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(125, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(24, 37);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 46);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(122, 39);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 46);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(122, 91);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 46);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 46);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            this.dgvLaboratorios.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(12, 238);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.RowHeadersWidth = 62;
            this.dgvLaboratorios.RowTemplate.Height = 28;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(766, 187);
            this.dgvLaboratorios.TabIndex = 6;
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.SkyBlue;
            this.grpAcciones.Controls.Add(this.btnGuardar);
            this.grpAcciones.Controls.Add(this.btnModificar);
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnLimpiar);
            this.grpAcciones.Location = new System.Drawing.Point(529, 56);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(249, 162);
            this.grpAcciones.TabIndex = 7;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // FrmLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.dgvLaboratorios);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Laboratorios";
            this.Load += new System.EventHandler(this.FrmLaboratorios_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.Label LblCapacidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}