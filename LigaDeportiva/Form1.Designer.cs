namespace LigaDeportiva
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnClubes = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugadores
            // 
            this.btnJugadores.Location = new System.Drawing.Point(51, 38);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(126, 51);
            this.btnJugadores.TabIndex = 0;
            this.btnJugadores.Text = "Gestionar Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.Location = new System.Drawing.Point(51, 116);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(126, 51);
            this.btnEquipos.TabIndex = 1;
            this.btnEquipos.Text = "Gestionar Equipos";
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnClubes
            // 
            this.btnClubes.Location = new System.Drawing.Point(51, 188);
            this.btnClubes.Name = "btnClubes";
            this.btnClubes.Size = new System.Drawing.Size(126, 51);
            this.btnClubes.TabIndex = 2;
            this.btnClubes.Text = "Gestionar Clubes";
            this.btnClubes.UseVisualStyleBackColor = true;
            this.btnClubes.Click += new System.EventHandler(this.btnClubes_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Location = new System.Drawing.Point(51, 263);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(126, 51);
            this.btnPartidos.TabIndex = 3;
            this.btnPartidos.Text = "Registrar Partido";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(51, 343);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(126, 51);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Generar Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(206, 38);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(126, 51);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.btnClubes);
            this.Controls.Add(this.btnEquipos);
            this.Controls.Add(this.btnJugadores);
            this.Name = "Form1";
            this.Text = "Liga Deportiva - Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnClubes;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnConsultas;
    }
}

