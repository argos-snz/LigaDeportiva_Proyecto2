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
using LigaDeportiva.Enums;

namespace LigaDeportiva
{
    public partial class FormPartido : Form
    {
        private GestorPartidos gestorPartidos;
        private GestorEquipos gestorEquipos;
        public FormPartido(GestorPartidos gestorPartidos, GestorEquipos gestorEquipos)
        {
            InitializeComponent();
            this.gestorPartidos = gestorPartidos;
            this.gestorEquipos = gestorEquipos;
        }

        private void FormPartido_Load(object sender, EventArgs e)
        {
            //cargamos las categorías en el ComboBox
            cmbCategoria.DataSource = Enum.GetValues(typeof(Categoria));
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenemos la categoría seleccionada
            Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;

            // Filtramos los equipos por categoría
            List<Equipo> equiposFiltrados = gestorEquipos.EquiposPorCategoria(categoriaSeleccionada);

            // Cargamos los equipos filtrados en ambos ComboBox
            cmbEquipoLocal.DataSource = null;
            cmbEquipoLocal.DataSource = new List<Equipo>(equiposFiltrados);
            cmbEquipoLocal.DisplayMember = "Nombre";

            cmbEquipoVisitante.DataSource = null;
            cmbEquipoVisitante.DataSource = new List<Equipo>(equiposFiltrados);
            cmbEquipoVisitante.DisplayMember = "Nombre";

            // Limpiamos los CheckedListBox
            cblTitularesLocal.Items.Clear();
            cblTitularesVisitante.Items.Clear();
            cblSuplentesLocal.Items.Clear();
            cblSuplentesVisitante.Items.Clear();
        }

        private void cmbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblTitularesLocal.Items.Clear();
            cblSuplentesLocal.Items.Clear();

            if (cmbEquipoLocal.SelectedItem is Equipo equipoLocal)
            {
                foreach (Jugador j in equipoLocal.Jugadores)
                {
                    cblTitularesLocal.Items.Add(j.Nombre + " " + j.Apellido);
                    cblSuplentesLocal.Items.Add(j.Nombre + " " + j.Apellido);
                }
            }
        }

        private void cblTitularesVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que haya categoría y equipos seleccionados
                if (cmbEquipoLocal.SelectedItem == null || cmbEquipoVisitante.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná ambos equipos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Equipo local = (Equipo)cmbEquipoLocal.SelectedItem;
                Equipo visitante = (Equipo)cmbEquipoVisitante.SelectedItem;

                if (local == visitante)
                {
                    MessageBox.Show("El equipo local y visitante no pueden ser el mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validamos exactamente 5 titulares por equipo
                if (cblTitularesLocal.CheckedItems.Count != 5)
                {
                    MessageBox.Show("Seleccioná exactamente 5 titulares para el equipo local.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cblTitularesVisitante.CheckedItems.Count != 5)
                {
                    MessageBox.Show("Seleccioná exactamente 5 titulares para el equipo visitante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validamos máximo 3 suplentes
                if (cblSuplentesLocal.CheckedItems.Count > 3)
                {
                    MessageBox.Show("El equipo local puede tener máximo 3 suplentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cblSuplentesVisitante.CheckedItems.Count > 3)
                {
                    MessageBox.Show("El equipo visitante puede tener máximo 3 suplentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validamos que el lugar del partido no esté vacío
                if (string.IsNullOrWhiteSpace(txtLugar.Text))
                {
                    MessageBox.Show("Ingresá el lugar del partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Armamos las listas de jugadores
                List<Jugador> titularesLocal = ObtenerJugadoresSeleccionados(cblTitularesLocal, local);
                List<Jugador> titularesVisitante = ObtenerJugadoresSeleccionados(cblTitularesVisitante, visitante);
                List<Jugador> suplentesLocal = ObtenerJugadoresSeleccionados(cblSuplentesLocal, local);
                List<Jugador> suplentesVisitante = ObtenerJugadoresSeleccionados(cblSuplentesVisitante, visitante);

                int golesLocal = int.Parse(txtGolesLocal.Text);
                int golesVisitante = int.Parse(txtGolesVisitante.Text);

                Partido nuevoPartido = new Partido(
                    (Categoria)cmbCategoria.SelectedItem,
                    local,
                    visitante,
                    titularesLocal,
                    suplentesLocal,
                    titularesVisitante,
                    suplentesVisitante,
                    dtFechaHora.Value,
                    txtLugar.Text,
                    golesLocal,
                    golesVisitante
                );

                gestorPartidos.AgregarPartido(nuevoPartido);
                MessageBox.Show("Partido registrado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Los goles deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Método auxiliar para obtener jugadores seleccionados en un CheckedListBox
        private List<Jugador> ObtenerJugadoresSeleccionados(CheckedListBox cbl, Equipo equipo)
        {
            List<Jugador> resultado = new List<Jugador>();

            foreach (string nombreCompleto in cbl.CheckedItems)
            {
                foreach (Jugador j in equipo.Jugadores)
                {
                    if ((j.Nombre + " " + j.Apellido) == nombreCompleto)
                    {
                        resultado.Add(j);
                        break;
                    }
                }
            }
            return resultado;
        }

        private void cmbEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblTitularesVisitante.Items.Clear();
            cblSuplentesVisitante.Items.Clear();

            if (cmbEquipoVisitante.SelectedItem is Equipo equipoVisitante)
            {
                foreach (Jugador j in equipoVisitante.Jugadores)
                {
                    cblTitularesVisitante.Items.Add(j.Nombre + " " + j.Apellido);
                    cblSuplentesVisitante.Items.Add(j.Nombre + " " + j.Apellido);
                }
            }
        }
    }
}
