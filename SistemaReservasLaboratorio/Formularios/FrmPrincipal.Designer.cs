namespace SistemaReservasLaboratorio
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaboratorios = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(197, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE RESERVAS DE LABORATORIOS";
            // 
            // btnLaboratorios
            // 
            this.btnLaboratorios.Location = new System.Drawing.Point(106, 243);
            this.btnLaboratorios.Name = "btnLaboratorios";
            this.btnLaboratorios.Size = new System.Drawing.Size(150, 50);
            this.btnLaboratorios.TabIndex = 2;
            this.btnLaboratorios.Text = "Laboratorios";
            this.btnLaboratorios.UseVisualStyleBackColor = true;
            this.btnLaboratorios.Click += new System.EventHandler(this.btnLaboratorios_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(418, 243);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(150, 50);
            this.btnReservas.TabIndex = 4;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(574, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(262, 243);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(150, 50);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLaboratorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reservas de Laboratorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaboratorios;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuarios;
    }
}

