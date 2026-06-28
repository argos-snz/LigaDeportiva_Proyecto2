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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.tabFormaciones = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbFormaciones = new System.Windows.Forms.RichTextBox();
            this.cmbPartidoFormaciones = new System.Windows.Forms.ComboBox();
            this.tabJugadoresPorEquipo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvJugadoresPorEquipo = new System.Windows.Forms.DataGridView();
            this.cmbEquipoFiltro = new System.Windows.Forms.ComboBox();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(-3, 32);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(673, 421);
            this.tab.TabIndex = 0;
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabHistorial.Controls.Add(this.dgvHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 25);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(665, 392);
            this.tabHistorial.TabIndex = 0;
            this.tabHistorial.Text = "Historial de Partidos";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.dgvHistorial.Location = new System.Drawing.Point(3, 3);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(658, 372);
            this.dgvHistorial.TabIndex = 0;
            // 
            // tabFormaciones
            // 
            this.tabFormaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabFormaciones.Controls.Add(this.label1);
            this.tabFormaciones.Controls.Add(this.rtbFormaciones);
            this.tabFormaciones.Controls.Add(this.cmbPartidoFormaciones);
            this.tabFormaciones.Location = new System.Drawing.Point(4, 25);
            this.tabFormaciones.Name = "tabFormaciones";
            this.tabFormaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormaciones.Size = new System.Drawing.Size(665, 392);
            this.tabFormaciones.TabIndex = 1;
            this.tabFormaciones.Text = "Formaciones";
            this.tabFormaciones.Click += new System.EventHandler(this.tabFormaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar partido:";
            // 
            // rtbFormaciones
            // 
            this.rtbFormaciones.BackColor = System.Drawing.Color.White;
            this.rtbFormaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFormaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbFormaciones.Location = new System.Drawing.Point(3, 36);
            this.rtbFormaciones.Name = "rtbFormaciones";
            this.rtbFormaciones.Size = new System.Drawing.Size(659, 338);
            this.rtbFormaciones.TabIndex = 1;
            this.rtbFormaciones.Text = "";
            // 
            // cmbPartidoFormaciones
            // 
            this.cmbPartidoFormaciones.BackColor = System.Drawing.Color.White;
            this.cmbPartidoFormaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmbPartidoFormaciones.FormattingEnabled = true;
            this.cmbPartidoFormaciones.Location = new System.Drawing.Point(154, 6);
            this.cmbPartidoFormaciones.Name = "cmbPartidoFormaciones";
            this.cmbPartidoFormaciones.Size = new System.Drawing.Size(287, 24);
            this.cmbPartidoFormaciones.TabIndex = 0;
            this.cmbPartidoFormaciones.SelectedIndexChanged += new System.EventHandler(this.cmbPartidoFormaciones_SelectedIndexChanged);
            // 
            // tabJugadoresPorEquipo
            // 
            this.tabJugadoresPorEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabJugadoresPorEquipo.Controls.Add(this.label2);
            this.tabJugadoresPorEquipo.Controls.Add(this.dgvJugadoresPorEquipo);
            this.tabJugadoresPorEquipo.Controls.Add(this.cmbEquipoFiltro);
            this.tabJugadoresPorEquipo.Location = new System.Drawing.Point(4, 25);
            this.tabJugadoresPorEquipo.Name = "tabJugadoresPorEquipo";
            this.tabJugadoresPorEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabJugadoresPorEquipo.Size = new System.Drawing.Size(665, 392);
            this.tabJugadoresPorEquipo.TabIndex = 2;
            this.tabJugadoresPorEquipo.Text = "Jugadores por Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar Equipo:";
            // 
            // dgvJugadoresPorEquipo
            // 
            this.dgvJugadoresPorEquipo.BackgroundColor = System.Drawing.Color.White;
            this.dgvJugadoresPorEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJugadoresPorEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJugadoresPorEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJugadoresPorEquipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvJugadoresPorEquipo.Location = new System.Drawing.Point(6, 57);
            this.dgvJugadoresPorEquipo.Name = "dgvJugadoresPorEquipo";
            this.dgvJugadoresPorEquipo.ReadOnly = true;
            this.dgvJugadoresPorEquipo.Size = new System.Drawing.Size(653, 317);
            this.dgvJugadoresPorEquipo.TabIndex = 1;
            this.dgvJugadoresPorEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadoresPorEquipo_CellContentClick);
            // 
            // cmbEquipoFiltro
            // 
            this.cmbEquipoFiltro.BackColor = System.Drawing.Color.White;
            this.cmbEquipoFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbEquipoFiltro.FormattingEnabled = true;
            this.cmbEquipoFiltro.Location = new System.Drawing.Point(150, 15);
            this.cmbEquipoFiltro.Name = "cmbEquipoFiltro";
            this.cmbEquipoFiltro.Size = new System.Drawing.Size(207, 24);
            this.cmbEquipoFiltro.TabIndex = 0;
            this.cmbEquipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoFiltro_SelectedIndexChanged);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabEstadisticas.Controls.Add(this.dgvEstadisticas);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 25);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadisticas.Size = new System.Drawing.Size(665, 392);
            this.tabEstadisticas.TabIndex = 3;
            this.tabEstadisticas.Text = "Tabla de Posiciones";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadisticas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadisticas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.dgvEstadisticas.Location = new System.Drawing.Point(6, 6);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.Size = new System.Drawing.Size(656, 369);
            this.dgvEstadisticas.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONSULTAS Y ESTADÍSTICAS";
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(671, 436);
            this.Controls.Add(this.label3);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
    }
}