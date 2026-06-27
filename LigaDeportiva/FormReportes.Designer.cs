namespace LigaDeportiva
{
    partial class FormReportes
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
            this.btnExportarJugadores = new System.Windows.Forms.Button();
            this.btnExportarEquipos = new System.Windows.Forms.Button();
            this.btnExportarClubes = new System.Windows.Forms.Button();
            this.btnExportarPartidos = new System.Windows.Forms.Button();
            this.btnExportarEstadisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExportarJugadores
            // 
            this.btnExportarJugadores.Location = new System.Drawing.Point(47, 52);
            this.btnExportarJugadores.Name = "btnExportarJugadores";
            this.btnExportarJugadores.Size = new System.Drawing.Size(110, 60);
            this.btnExportarJugadores.TabIndex = 0;
            this.btnExportarJugadores.Text = "JUGADORES";
            this.btnExportarJugadores.UseVisualStyleBackColor = true;
            this.btnExportarJugadores.Click += new System.EventHandler(this.btnExportarJugadores_Click);
            // 
            // btnExportarEquipos
            // 
            this.btnExportarEquipos.Location = new System.Drawing.Point(204, 52);
            this.btnExportarEquipos.Name = "btnExportarEquipos";
            this.btnExportarEquipos.Size = new System.Drawing.Size(110, 60);
            this.btnExportarEquipos.TabIndex = 1;
            this.btnExportarEquipos.Text = "EQUIPOS";
            this.btnExportarEquipos.UseVisualStyleBackColor = true;
            this.btnExportarEquipos.Click += new System.EventHandler(this.btnExportarEquipos_Click);
            // 
            // btnExportarClubes
            // 
            this.btnExportarClubes.Location = new System.Drawing.Point(284, 131);
            this.btnExportarClubes.Name = "btnExportarClubes";
            this.btnExportarClubes.Size = new System.Drawing.Size(110, 60);
            this.btnExportarClubes.TabIndex = 2;
            this.btnExportarClubes.Text = "CLUBES";
            this.btnExportarClubes.UseVisualStyleBackColor = true;
            this.btnExportarClubes.Click += new System.EventHandler(this.btnExportarClubes_Click);
            // 
            // btnExportarPartidos
            // 
            this.btnExportarPartidos.Location = new System.Drawing.Point(122, 131);
            this.btnExportarPartidos.Name = "btnExportarPartidos";
            this.btnExportarPartidos.Size = new System.Drawing.Size(110, 60);
            this.btnExportarPartidos.TabIndex = 3;
            this.btnExportarPartidos.Text = "HISTORIAL DE PARTIDOS";
            this.btnExportarPartidos.UseVisualStyleBackColor = true;
            this.btnExportarPartidos.Click += new System.EventHandler(this.btnExportarPartidos_Click);
            // 
            // btnExportarEstadisticas
            // 
            this.btnExportarEstadisticas.Location = new System.Drawing.Point(354, 52);
            this.btnExportarEstadisticas.Name = "btnExportarEstadisticas";
            this.btnExportarEstadisticas.Size = new System.Drawing.Size(110, 60);
            this.btnExportarEstadisticas.TabIndex = 4;
            this.btnExportarEstadisticas.Text = "ESTADÍSTICAS";
            this.btnExportarEstadisticas.UseVisualStyleBackColor = true;
            this.btnExportarEstadisticas.Click += new System.EventHandler(this.btnExportarEstadisticas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECCIONE EL REPORTE QUE DESEA EXPORTAR:";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(18, 225);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(477, 217);
            this.rtbResultado.TabIndex = 6;
            this.rtbResultado.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Visualización del reporte:";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarEstadisticas);
            this.Controls.Add(this.btnExportarPartidos);
            this.Controls.Add(this.btnExportarClubes);
            this.Controls.Add(this.btnExportarEquipos);
            this.Controls.Add(this.btnExportarJugadores);
            this.Name = "FormReportes";
            this.Text = "REPORTES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportarJugadores;
        private System.Windows.Forms.Button btnExportarEquipos;
        private System.Windows.Forms.Button btnExportarClubes;
        private System.Windows.Forms.Button btnExportarPartidos;
        private System.Windows.Forms.Button btnExportarEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label2;
    }
}