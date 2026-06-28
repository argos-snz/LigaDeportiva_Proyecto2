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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cblSuplentesLocal = new System.Windows.Forms.CheckedListBox();
            this.cblTitularesLocal = new System.Windows.Forms.CheckedListBox();
            this.titularesVisitante = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cblSuplentesVisitante = new System.Windows.Forms.CheckedListBox();
            this.cblTitularesVisitante = new System.Windows.Forms.CheckedListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.titularesLocal.SuspendLayout();
            this.titularesVisitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(187, 42);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(136, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbEquipoLocal
            // 
            this.cmbEquipoLocal.BackColor = System.Drawing.Color.White;
            this.cmbEquipoLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbEquipoLocal.FormattingEnabled = true;
            this.cmbEquipoLocal.Location = new System.Drawing.Point(187, 83);
            this.cmbEquipoLocal.Name = "cmbEquipoLocal";
            this.cmbEquipoLocal.Size = new System.Drawing.Size(136, 21);
            this.cmbEquipoLocal.TabIndex = 1;
            this.cmbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoLocal_SelectedIndexChanged);
            // 
            // cmbEquipoVisitante
            // 
            this.cmbEquipoVisitante.BackColor = System.Drawing.Color.White;
            this.cmbEquipoVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbEquipoVisitante.FormattingEnabled = true;
            this.cmbEquipoVisitante.Location = new System.Drawing.Point(187, 122);
            this.cmbEquipoVisitante.Name = "cmbEquipoVisitante";
            this.cmbEquipoVisitante.Size = new System.Drawing.Size(136, 21);
            this.cmbEquipoVisitante.TabIndex = 2;
            this.cmbEquipoVisitante.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoVisitante_SelectedIndexChanged);
            // 
            // dtFechaHora
            // 
            this.dtFechaHora.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHora.CalendarForeColor = System.Drawing.Color.White;
            this.dtFechaHora.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtFechaHora.Location = new System.Drawing.Point(470, 38);
            this.dtFechaHora.Name = "dtFechaHora";
            this.dtFechaHora.Size = new System.Drawing.Size(148, 20);
            this.dtFechaHora.TabIndex = 3;
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Location = new System.Drawing.Point(464, 147);
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(39, 20);
            this.txtGolesLocal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATOS DEL PARTIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar Visitante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(374, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
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
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(420, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lugar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(486, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "RESULTADO";
            // 
            // txtGolesVisitante
            // 
            this.txtGolesVisitante.Location = new System.Drawing.Point(547, 147);
            this.txtGolesVisitante.Name = "txtGolesVisitante";
            this.txtGolesVisitante.Size = new System.Drawing.Size(39, 20);
            this.txtGolesVisitante.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(520, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(415, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Local";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(592, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Visitante";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // titularesLocal
            // 
            this.titularesLocal.Controls.Add(this.label12);
            this.titularesLocal.Controls.Add(this.label11);
            this.titularesLocal.Controls.Add(this.cblSuplentesLocal);
            this.titularesLocal.Controls.Add(this.cblTitularesLocal);
            this.titularesLocal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titularesLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.titularesLocal.Location = new System.Drawing.Point(38, 197);
            this.titularesLocal.Name = "titularesLocal";
            this.titularesLocal.Size = new System.Drawing.Size(308, 285);
            this.titularesLocal.TabIndex = 17;
            this.titularesLocal.TabStop = false;
            this.titularesLocal.Text = "Equipo Local:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "SUPLENTES";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "TITULARES";
            // 
            // cblSuplentesLocal
            // 
            this.cblSuplentesLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cblSuplentesLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblSuplentesLocal.ForeColor = System.Drawing.Color.White;
            this.cblSuplentesLocal.FormattingEnabled = true;
            this.cblSuplentesLocal.Location = new System.Drawing.Point(7, 163);
            this.cblSuplentesLocal.Name = "cblSuplentesLocal";
            this.cblSuplentesLocal.Size = new System.Drawing.Size(295, 108);
            this.cblSuplentesLocal.TabIndex = 1;
            // 
            // cblTitularesLocal
            // 
            this.cblTitularesLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cblTitularesLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblTitularesLocal.ForeColor = System.Drawing.Color.White;
            this.cblTitularesLocal.FormattingEnabled = true;
            this.cblTitularesLocal.Location = new System.Drawing.Point(7, 33);
            this.cblTitularesLocal.Name = "cblTitularesLocal";
            this.cblTitularesLocal.Size = new System.Drawing.Size(295, 108);
            this.cblTitularesLocal.TabIndex = 0;
            // 
            // titularesVisitante
            // 
            this.titularesVisitante.Controls.Add(this.label14);
            this.titularesVisitante.Controls.Add(this.label13);
            this.titularesVisitante.Controls.Add(this.cblSuplentesVisitante);
            this.titularesVisitante.Controls.Add(this.cblTitularesVisitante);
            this.titularesVisitante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titularesVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.titularesVisitante.Location = new System.Drawing.Point(371, 197);
            this.titularesVisitante.Name = "titularesVisitante";
            this.titularesVisitante.Size = new System.Drawing.Size(308, 285);
            this.titularesVisitante.TabIndex = 18;
            this.titularesVisitante.TabStop = false;
            this.titularesVisitante.Text = "Equipo Visitante:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "SUPLENTES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "TITULARES";
            // 
            // cblSuplentesVisitante
            // 
            this.cblSuplentesVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cblSuplentesVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblSuplentesVisitante.ForeColor = System.Drawing.Color.White;
            this.cblSuplentesVisitante.FormattingEnabled = true;
            this.cblSuplentesVisitante.Location = new System.Drawing.Point(7, 163);
            this.cblSuplentesVisitante.Name = "cblSuplentesVisitante";
            this.cblSuplentesVisitante.Size = new System.Drawing.Size(295, 108);
            this.cblSuplentesVisitante.TabIndex = 2;
            this.cblSuplentesVisitante.SelectedIndexChanged += new System.EventHandler(this.cblSuplentesVisitante_SelectedIndexChanged);
            // 
            // cblTitularesVisitante
            // 
            this.cblTitularesVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cblTitularesVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblTitularesVisitante.ForeColor = System.Drawing.Color.White;
            this.cblTitularesVisitante.FormattingEnabled = true;
            this.cblTitularesVisitante.Location = new System.Drawing.Point(7, 33);
            this.cblTitularesVisitante.Name = "cblTitularesVisitante";
            this.cblTitularesVisitante.Size = new System.Drawing.Size(295, 108);
            this.cblTitularesVisitante.TabIndex = 1;
            this.cblTitularesVisitante.SelectedIndexChanged += new System.EventHandler(this.cblTitularesVisitante_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(135)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(276, 501);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 30);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "REGISTRAR PARTIDO";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FormPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
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