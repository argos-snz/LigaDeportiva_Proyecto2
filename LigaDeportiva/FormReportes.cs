using LigaDeportiva.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaDeportiva
{
    public partial class FormReportes : Form
    {
        private GestorJugadores gestorJugadores;
        private GestorEquipos gestorEquipos;
        private GestorClubes gestorClubes;
        private GestorPartidos gestorPartidos;

        public FormReportes(GestorJugadores gestorJugadores, GestorEquipos gestorEquipos, GestorClubes gestorClubes, GestorPartidos gestorPartidos)
        {
            InitializeComponent();
            this.gestorJugadores = gestorJugadores;
            this.gestorEquipos = gestorEquipos;
            this.gestorClubes = gestorClubes;
            this.gestorPartidos = gestorPartidos;

        }

        private void btnExportarJugadores_Click(object sender, EventArgs e)
        {
            string ruta = "jugadores.txt";
            if (gestorJugadores.ExportarDatosTxt(ruta))
            {
                MessageBox.Show("Archivo exportado: " + ruta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbResultado.Text = System.IO.File.ReadAllText(ruta);
            }
            else
                MessageBox.Show("Error al exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnExportarEquipos_Click(object sender, EventArgs e)
        {
            string ruta = "equipos.txt";
            if (gestorEquipos.ExportarDatosTxt(ruta))
            { 
                MessageBox.Show("Archivo exportado: " + ruta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                rtbResultado.Text = System.IO.File.ReadAllText(ruta); 
            }
            else
                MessageBox.Show("Error al exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExportarPartidos_Click(object sender, EventArgs e)
        {
            string ruta = "partidos.txt";
            if (gestorPartidos.ExportarDatosTxt(ruta))
            { 
                MessageBox.Show("Archivo exportado: " + ruta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                rtbResultado.Text = System.IO.File.ReadAllText(ruta); 
            }
            else
                MessageBox.Show("Error al exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        


        private void btnExportarClubes_Click(object sender, EventArgs e)
        {
            string ruta = "clubes.txt";
            if (gestorClubes.ExportarDatosTxt(ruta))
            { 
                MessageBox.Show("Archivo exportado: " + ruta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                rtbResultado.Text = System.IO.File.ReadAllText(ruta); 
            }
            else
                MessageBox.Show("Error al exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void btnExportarEstadisticas_Click(object sender, EventArgs e)
        {
            string ruta = "estadisticas.txt";
            List<Equipo> equipos = gestorEquipos.MostrarEquipos();
            if (gestorPartidos.ExportarEstadisticasTxt(ruta, equipos))
            { 
                MessageBox.Show("Archivo exportado: " + ruta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                rtbResultado.Text = System.IO.File.ReadAllText(ruta); 
            }
            else
                MessageBox.Show("Error al exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void rtbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
