using LigaDeportiva.Clases;
using LigaDeportiva.Enums;
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
    public partial class FormEquipos : Form
    {
        private GestorEquipos gestorEquipos;
        private GestorClubes gestorClubes;

        public FormEquipos(GestorClubes gestorClubes, GestorEquipos gestorEquipos)
        {
            InitializeComponent();
            this.gestorClubes = gestorClubes;
            this.gestorEquipos = gestorEquipos;
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {

            // carga los clubes en el ComboBox 
            cmbClubes.DataSource = null;
            cmbClubes.DataSource = gestorClubes.MostrarClubes();
            cmbClubes.DisplayMember = "Nombre"; // lo que el usuario ve

            //cargar las categorías (usando Enum.GetValues para que sea automático)
            cmbCategorias.DataSource = Enum.GetValues(typeof(Categoria));

            ActualizarGrilla();

            // Esto hace que las columnas ocupen automáticamente todo el ancho disponible
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        /// <summary>
        /// Actualiza la grilla de equipos y oculta las columnas con los nombres de objetos completos
        /// y agrega una columna manual con el nombre del club.
        /// </summary>
        private void ActualizarGrilla()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = gestorEquipos.MostrarEquipos();



            if (dgvEquipos.Columns["Club"] != null)
                dgvEquipos.Columns["Club"].Visible = false;

            if (dgvEquipos.Columns["Jugadores"] != null)
                dgvEquipos.Columns["Jugadores"].Visible = false;

            // Agregamos columna manual con el nombre del club
            if (!dgvEquipos.Columns.Contains("NombreClub"))
            {
                DataGridViewTextBoxColumn colClub = new DataGridViewTextBoxColumn();
                colClub.HeaderText = "Club";
                colClub.Name = "NombreClub";
                dgvEquipos.Columns.Add(colClub);
            }

            foreach (DataGridViewRow fila in dgvEquipos.Rows)
            {
                if (fila.DataBoundItem is Equipo eq)
                    fila.Cells["NombreClub"].Value = eq.Club.Nombre;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Evento para agregar: Usa los ComboBox para seleccionar el club y la categoría, y luego llama al método AgregarEquipo del gestor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Club clubSeleccionado = (Club)cmbClubes.SelectedItem;
            Categoria categoriaSeleccionada = (Categoria)cmbCategorias.SelectedItem;

            if (clubSeleccionado != null)
            {
                gestorEquipos.AgregarEquipo(clubSeleccionado, categoriaSeleccionada);
                ActualizarGrilla(); // Refrescamos la grilla
                MessageBox.Show("Equipo registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un club antes de agregar.");
            }
        }

        // Evento para eliminar: Usamos el nombre del equipo seleccionado en la grilla
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                string nombreEquipo = dgvEquipos.SelectedRows[0].Cells["Nombre"].Value.ToString();

                DialogResult res = MessageBox.Show($"¿Eliminar equipo {nombreEquipo}?", "Confirmar", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    if (gestorEquipos.EliminarEquipo(nombreEquipo))
                    {
                        ActualizarGrilla();
                        MessageBox.Show("Equipo eliminado.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar (quizás tiene jugadores asignados).");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná una fila de la grilla para eliminar.");
            }
        }
    }
}
