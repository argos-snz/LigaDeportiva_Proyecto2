namespace LigaDeportiva
{
    partial class FormPartido
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEquipoLocal = new System.Windows.Forms.ComboBox();
            this.cmbEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.dtFechaHora = new System.Windows.Forms.DateTimePicker();
            this.txtGolesLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGolesVisitante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titularesLocal = new System.Windows.Forms.GroupBox();
            this.cblSuplentesLocal = new System.Windows.Forms.CheckedListBox();
            this.cblTitularesLocal = new System.Windows.Forms.CheckedListBox();
            this.titularesVisitante = new System.Windows.Forms.GroupBox();
            this.cblSuplentesVisitante = new System.Windows.Forms.CheckedListBox();
            this.cblTitularesVisitante = new System.Windows.Forms.CheckedListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.titularesLocal.SuspendLayout();
            this.titularesVisitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(143, 38);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(144, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbEquipoLocal
            // 
            this.cmbEquipoLocal.FormattingEnabled = true;
            this.cmbEquipoLocal.Location = new System.Drawing.Point(143, 84);
            this.cmbEquipoLocal.Name = "cmbEquipoLocal";
            this.cmbEquipoLocal.Size = new System.Drawing.Size(144, 21);
            this.cmbEquipoLocal.TabIndex = 1;
            this.cmbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoLocal_SelectedIndexChanged);
            // 
            // cmbEquipoVisitante
            // 
            this.cmbEquipoVisitante.FormattingEnabled = true;
            this.cmbEquipoVisitante.Location = new System.Drawing.Point(143, 134);
            this.cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            this.cmbEquipoVisitante.Size = new System.Drawing.Size(144, 21);
            this.cmbEquipoVisitante.TabIndex = 2;
            this.cmbEquipoVisitante.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoVisitante_SelectedIndexChanged);
            // 
            // dtFechaHora
            // 
            this.dtFechaHora.Location = new System.Drawing.Point(470, 38);
            this.dtFechaHora.Name = "dtFechaHora";
            this.dtFechaHora.Size = new System.Drawing.Size(148, 20);
            this.dtFechaHora.TabIndex = 3;
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Location = new System.Drawing.Point(478, 137);
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(39, 20);
            this.txtGolesLocal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATOS DEL PARTIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar Visitante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora y fecha";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(470, 75);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(148, 20);
            this.txtLugar.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lugar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "RESULTADO";
            // 
            // txtGolesVisitante
            // 
            this.txtGolesVisitante.Location = new System.Drawing.Point(561, 137);
            this.txtGolesVisitante.Name = "txtGolesVisitante";
            this.txtGolesVisitante.Size = new System.Drawing.Size(39, 20);
            this.txtGolesVisitante.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Local";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Visitante";
            // 
            // titularesLocal
            // 
            this.titularesLocal.Controls.Add(this.label12);
            this.titularesLocal.Controls.Add(this.label11);
            this.titularesLocal.Controls.Add(this.cblSuplentesLocal);
            this.titularesLocal.Controls.Add(this.cblTitularesLocal);
            this.titularesLocal.Location = new System.Drawing.Point(38, 197);
            this.titularesLocal.Name = "titularesLocal";
            this.titularesLocal.Size = new System.Drawing.Size(308, 285);
            this.titularesLocal.TabIndex = 17;
            this.titularesLocal.TabStop = false;
            this.titularesLocal.Text = "Equipo Local:";
            // 
            // cblSuplentesLocal
            // 
            this.cblSuplentesLocal.FormattingEnabled = true;
            this.cblSuplentesLocal.Location = new System.Drawing.Point(7, 163);
            this.cblSuplentesLocal.Name = "cblSuplentesLocal";
            this.cblSuplentesLocal.Size = new System.Drawing.Size(295, 109);
            this.cblSuplentesLocal.TabIndex = 1;
            // 
            // cblTitularesLocal
            // 
            this.cblTitularesLocal.FormattingEnabled = true;
            this.cblTitularesLocal.Location = new System.Drawing.Point(7, 33);
            this.cblTitularesLocal.Name = "cblTitularesLocal";
            this.cblTitularesLocal.Size = new System.Drawing.Size(295, 109);
            this.cblTitularesLocal.TabIndex = 0;
            // 
            // titularesVisitante
            // 
            this.titularesVisitante.Controls.Add(this.label14);
            this.titularesVisitante.Controls.Add(this.label13);
            this.titularesVisitante.Controls.Add(this.cblSuplentesVisitante);
            this.titularesVisitante.Controls.Add(this.cblTitularesVisitante);
            this.titularesVisitante.Location = new System.Drawing.Point(371, 197);
            this.titularesVisitante.Name = "titularesVisitante";
            this.titularesVisitante.Size = new System.Drawing.Size(308, 285);
            this.titularesVisitante.TabIndex = 18;
            this.titularesVisitante.TabStop = false;
            this.titularesVisitante.Text = "Equipo Visitante:";
            // 
            // cblSuplentesVisitante
            // 
            this.cblSuplentesVisitante.FormattingEnabled = true;
            this.cblSuplentesVisitante.Location = new System.Drawing.Point(7, 163);
            this.cblSuplentesVisitante.Name = "cblSuplentesVisitante";
            this.cblSuplentesVisitante.Size = new System.Drawing.Size(295, 109);
            this.cblSuplentesVisitante.TabIndex = 2;
            // 
            // cblTitularesVisitante
            // 
            this.cblTitularesVisitante.FormattingEnabled = true;
            this.cblTitularesVisitante.Location = new System.Drawing.Point(7, 33);
            this.cblTitularesVisitante.Name = "cblTitularesVisitante";
            this.cblTitularesVisitante.Size = new System.Drawing.Size(295, 109);
            this.cblTitularesVisitante.TabIndex = 1;
            this.cblTitularesVisitante.SelectedIndexChanged += new System.EventHandler(this.cblTitularesVisitante_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(276, 501);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 30);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "REGISTRAR PARTIDO";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "TITULARES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "SUPLENTES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "TITULARES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "SUPLENTES";
            // 
            // FormPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(713, 543);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.titularesVisitante);
            this.Controls.Add(this.titularesLocal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGolesVisitante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGolesLocal);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.dtFechaHora);
            this.Controls.Add(this.cmbEquipoVisitante);
            this.Controls.Add(this.cmbEquipoLocal);
            this.Controls.Add(this.cmbCategoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPartido";
            this.Text = "Registro de Partido";
            this.Load += new System.EventHandler(this.FormPartido_Load);
            this.titularesLocal.ResumeLayout(false);
            this.titularesLocal.PerformLayout();
            this.titularesVisitante.ResumeLayout(false);
            this.titularesVisitante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbEquipoLocal;
        private System.Windows.Forms.ComboBox cmbEquipoVisitante;
        private System.Windows.Forms.DateTimePicker dtFechaHora;
        private System.Windows.Forms.TextBox txtGolesLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGolesVisitante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox titularesLocal;
        private System.Windows.Forms.GroupBox titularesVisitante;
        private System.Windows.Forms.CheckedListBox cblTitularesLocal;
        private System.Windows.Forms.CheckedListBox cblTitularesVisitante;
        private System.Windows.Forms.CheckedListBox cblSuplentesLocal;
        private System.Windows.Forms.CheckedListBox cblSuplentesVisitante;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}