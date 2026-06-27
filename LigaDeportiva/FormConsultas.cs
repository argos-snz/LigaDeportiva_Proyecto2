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
    public partial class FormConsultas : Form
    {
        private GestorPartidos gestorPartidos;
        private GestorEquipos gestorEquipos;
        private GestorJugadores gestorJugadores;

        public FormConsultas(GestorPartidos gestorPartidos, GestorEquipos gestorEquipos, GestorJugadores gestorJugadores)
        {
            InitializeComponent();
            this.gestorPartidos = gestorPartidos;
            this.gestorEquipos = gestorEquipos;
            this.gestorJugadores = gestorJugadores;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            CargarHistorial();
            CargarEstadisticas();
            CargarComboPartidos();
            CargarComboEquipos();
        }

        // pestaña 1 - Historial
        private void CargarHistorial()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = gestorPartidos.MostrarPartidos();

            if (dgvHistorial.Columns["EquipoLocal"] != null)
                dgvHistorial.Columns["EquipoLocal"].Visible = false;
            if (dgvHistorial.Columns["EquipoVisitante"] != null)
                dgvHistorial.Columns["EquipoVisitante"].Visible = false;
            if (dgvHistorial.Columns["TitularesLocal"] != null)
                dgvHistorial.Columns["TitularesLocal"].Visible = false;
            if (dgvHistorial.Columns["TitularesVisitante"] != null)
                dgvHistorial.Columns["TitularesVisitante"].Visible = false;
            if (dgvHistorial.Columns["SuplentesLocal"] != null)
                dgvHistorial.Columns["SuplentesLocal"].Visible = false;
            if (dgvHistorial.Columns["SuplentesVisitante"] != null)
                dgvHistorial.Columns["SuplentesVisitante"].Visible = false;

            // Columnas manuales
            if (!dgvHistorial.Columns.Contains("Local"))
            {
                DataGridViewTextBoxColumn colLocal = new DataGridViewTextBoxColumn();
                colLocal.HeaderText = "Local";
                colLocal.Name = "Local";
                dgvHistorial.Columns.Add(colLocal);

                DataGridViewTextBoxColumn colVisitante = new DataGridViewTextBoxColumn();
                colVisitante.HeaderText = "Visitante";
                colVisitante.Name = "Visitante";
                dgvHistorial.Columns.Add(colVisitante);
            }

            foreach (DataGridViewRow fila in dgvHistorial.Rows)
            {
                if (fila.DataBoundItem is Partido p)
                {
                    fila.Cells["Local"].Value = p.EquipoLocal.Nombre;
                    fila.Cells["Visitante"].Value = p.EquipoVisitante.Nombre;
                }
            }

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //pestaña 2 - Formaciones
        private void CargarComboPartidos()
        {
            List<Partido> partidos = gestorPartidos.MostrarPartidos();
            cmbPartidoFormaciones.Items.Clear();

            foreach (Partido p in partidos)
            {
                string descripcion = p.EquipoLocal.Nombre + " vs " + p.EquipoVisitante.Nombre + " - " + p.FechaHorario.ToShortDateString();
                cmbPartidoFormaciones.Items.Add(descripcion);
            }

            if (cmbPartidoFormaciones.Items.Count > 0)
                cmbPartidoFormaciones.SelectedIndex = 0;
        }

        private void cmbPartidoFormaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbPartidoFormaciones.SelectedIndex;
            if (indice < 0) return;

            Partido p = gestorPartidos.MostrarPartidos()[indice];

            rtbFormaciones.Clear();
            rtbFormaciones.AppendText("=== " + p.EquipoLocal.Nombre + " ===\n");
            rtbFormaciones.AppendText("Titulares:\n");
            foreach (Jugador j in p.TitularesLocal)
                rtbFormaciones.AppendText("  - " + j.Nombre + " " + j.Apellido + "\n");
            rtbFormaciones.AppendText("Suplentes:\n");
            foreach (Jugador j in p.SuplentesLocal)
                rtbFormaciones.AppendText("  - " + j.Nombre + " " + j.Apellido + "\n");

            rtbFormaciones.AppendText("\n=== " + p.EquipoVisitante.Nombre + " ===\n");
            rtbFormaciones.AppendText("Titulares:\n");
            foreach (Jugador j in p.TitularesVisitante)
                rtbFormaciones.AppendText("  - " + j.Nombre + " " + j.Apellido + "\n");
            rtbFormaciones.AppendText("Suplentes:\n");
            foreach (Jugador j in p.SuplentesVisitante)
                rtbFormaciones.AppendText("  - " + j.Nombre + " " + j.Apellido + "\n");
        }

        //pestaña 3 - Jugadores por equipo
        private void CargarComboEquipos()
        {
            cmbEquipoFiltro.DataSource = gestorEquipos.MostrarEquipos();
            cmbEquipoFiltro.DisplayMember = "Nombre";
        }

        private void cmbEquipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipoFiltro.SelectedItem is Equipo equipoSeleccionado)
            {
                dgvJugadoresPorEquipo.DataSource = null;
                dgvJugadoresPorEquipo.DataSource = equipoSeleccionado.Jugadores;
                dgvJugadoresPorEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvJugadoresPorEquipo.Columns["Equipos"] != null)
                    dgvJugadoresPorEquipo.Columns["Equipos"].Visible = false;
            }
        }

        //pestaña 4 - Estadísticas
        private void CargarEstadisticas()
        {
            List<Equipo> equipos = gestorEquipos.MostrarEquipos();
            List<EstadisticasEquipo> stats = gestorPartidos.CalcularEstadisticas(equipos);

            dgvEstadisticas.DataSource = null;
            dgvEstadisticas.Columns.Clear();

            // Agregamos columnas manuales primero
            dgvEstadisticas.Columns.Add("Equipo", "Equipo");
            dgvEstadisticas.Columns.Add("PJ", "PJ");
            dgvEstadisticas.Columns.Add("PG", "PG");
            dgvEstadisticas.Columns.Add("PE", "PE");
            dgvEstadisticas.Columns.Add("PP", "PP");
            dgvEstadisticas.Columns.Add("Puntos", "Puntos");

            // Llenamos fila por fila
            foreach (EstadisticasEquipo s in stats)
            {
                dgvEstadisticas.Rows.Add(
                    s.EquipoAsociado.Nombre,
                    s.PartidosJugados,
                    s.PartidosGanados,
                    s.PartidosEmpatados,
                    s.PartidosPerdidos,
                    s.Puntos
                );
            }

            dgvEstadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
