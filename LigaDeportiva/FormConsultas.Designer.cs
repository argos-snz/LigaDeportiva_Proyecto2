namespace LigaDeportiva
{
    partial class FormConsultas
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.tabFormaciones = new System.Windows.Forms.TabPage();
            this.rtbFormaciones = new System.Windows.Forms.RichTextBox();
            this.cmbPartidoFormaciones = new System.Windows.Forms.ComboBox();
            this.tabJugadoresPorEquipo = new System.Windows.Forms.TabPage();
            this.dgvJugadoresPorEquipo = new System.Windows.Forms.DataGridView();
            this.cmbEquipoFiltro = new System.Windows.Forms.ComboBox();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.tabFormaciones.SuspendLayout();
            this.tabJugadoresPorEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresPorEquipo)).BeginInit();
            this.tabEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabHistorial);
            this.tab.Controls.Add(this.tabFormaciones);
            this.tab.Controls.Add(this.tabJugadoresPorEquipo);
            this.tab.Controls.Add(this.tabEstadisticas);
            this.tab.Location = new System.Drawing.Point(-4, 2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(690, 451);
            this.tab.TabIndex = 0;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.dgvHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(682, 425);
            this.tabHistorial.TabIndex = 0;
            this.tabHistorial.Text = "Historial de Partidos";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 22);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(658, 382);
            this.dgvHistorial.TabIndex = 0;
            // 
            // tabFormaciones
            // 
            this.tabFormaciones.Controls.Add(this.label1);
            this.tabFormaciones.Controls.Add(this.rtbFormaciones);
            this.tabFormaciones.Controls.Add(this.cmbPartidoFormaciones);
            this.tabFormaciones.Location = new System.Drawing.Point(4, 22);
            this.tabFormaciones.Name = "tabFormaciones";
            this.tabFormaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormaciones.Size = new System.Drawing.Size(682, 425);
            this.tabFormaciones.TabIndex = 1;
            this.tabFormaciones.Text = "Formaciones";
            this.tabFormaciones.UseVisualStyleBackColor = true;
            // 
            // rtbFormaciones
            // 
            this.rtbFormaciones.Location = new System.Drawing.Point(12, 60);
            this.rtbFormaciones.Name = "rtbFormaciones";
            this.rtbFormaciones.Size = new System.Drawing.Size(650, 353);
            this.rtbFormaciones.TabIndex = 1;
            this.rtbFormaciones.Text = "";
            // 
            // cmbPartidoFormaciones
            // 
            this.cmbPartidoFormaciones.FormattingEnabled = true;
            this.cmbPartidoFormaciones.Location = new System.Drawing.Point(119, 22);
            this.cmbPartidoFormaciones.Name = "cmbPartidoFormaciones";
            this.cmbPartidoFormaciones.Size = new System.Drawing.Size(231, 21);
            this.cmbPartidoFormaciones.TabIndex = 0;
            this.cmbPartidoFormaciones.SelectedIndexChanged += new System.EventHandler(this.cmbPartidoFormaciones_SelectedIndexChanged);
            // 
            // tabJugadoresPorEquipo
            // 
            this.tabJugadoresPorEquipo.Controls.Add(this.label2);
            this.tabJugadoresPorEquipo.Controls.Add(this.dgvJugadoresPorEquipo);
            this.tabJugadoresPorEquipo.Controls.Add(this.cmbEquipoFiltro);
            this.tabJugadoresPorEquipo.Location = new System.Drawing.Point(4, 22);
            this.tabJugadoresPorEquipo.Name = "tabJugadoresPorEquipo";
            this.tabJugadoresPorEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabJugadoresPorEquipo.Size = new System.Drawing.Size(682, 425);
            this.tabJugadoresPorEquipo.TabIndex = 2;
            this.tabJugadoresPorEquipo.Text = "Jugadores por Equipo";
            this.tabJugadoresPorEquipo.UseVisualStyleBackColor = true;
            // 
            // dgvJugadoresPorEquipo
            // 
            this.dgvJugadoresPorEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadoresPorEquipo.Location = new System.Drawing.Point(19, 51);
            this.dgvJugadoresPorEquipo.Name = "dgvJugadoresPorEquipo";
            this.dgvJugadoresPorEquipo.Size = new System.Drawing.Size(634, 347);
            this.dgvJugadoresPorEquipo.TabIndex = 1;
            // 
            // cmbEquipoFiltro
            // 
            this.cmbEquipoFiltro.FormattingEnabled = true;
            this.cmbEquipoFiltro.Location = new System.Drawing.Point(124, 20);
            this.cmbEquipoFiltro.Name = "cmbEquipoFiltro";
            this.cmbEquipoFiltro.Size = new System.Drawing.Size(207, 21);
            this.cmbEquipoFiltro.TabIndex = 0;
            this.cmbEquipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoFiltro_SelectedIndexChanged);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Controls.Add(this.dgvEstadisticas);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadisticas.Size = new System.Drawing.Size(682, 425);
            this.tabEstadisticas.TabIndex = 3;
            this.tabEstadisticas.Text = "Tabla de Posiciones";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(6, 22);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.Size = new System.Drawing.Size(666, 392);
            this.dgvEstadisticas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar partido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar Equipo:";
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.tab);
            this.Name = "FormConsultas";
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.tab.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.tabFormaciones.ResumeLayout(false);
            this.tabFormaciones.PerformLayout();
            this.tabJugadoresPorEquipo.ResumeLayout(false);
            this.tabJugadoresPorEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresPorEquipo)).EndInit();
            this.tabEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabFormaciones;
        private System.Windows.Forms.TabPage tabJugadoresPorEquipo;
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.RichTextBox rtbFormaciones;
        private System.Windows.Forms.ComboBox cmbPartidoFormaciones;
        private System.Windows.Forms.DataGridView dgvJugadoresPorEquipo;
        private System.Windows.Forms.ComboBox cmbEquipoFiltro;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}