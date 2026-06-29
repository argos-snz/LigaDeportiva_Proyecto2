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
    public partial class FormClubes : Form
    {
        private GestorClubes gestorClubes;

        public FormClubes(GestorClubes gestorClubes)
        {
            InitializeComponent();
            this.gestorClubes = gestorClubes;
        }

        private void FormClubes_Load(object sender, EventArgs e)
        {
            ActualizarLista();

            // Esto hace que las columnas ocupen automáticamente todo el ancho disponible
            dgvClubes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ActualizarLista()
        {
            dgvClubes.DataSource = null;
            dgvClubes.DataSource = gestorClubes.MostrarClubes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            // Validamos que no esté vacío
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                gestorClubes.AgregarClub(nombre);
                MessageBox.Show("Club agregado con éxito.");
                txtNombre.Clear(); // Limpiamos para el próximo
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, ingresá un nombre válido.");
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClubes.SelectedRows.Count > 0)
            {
                string nombre = dgvClubes.SelectedRows[0].Cells["Nombre"].Value.ToString();

                DialogResult respuesta = MessageBox.Show($"¿Eliminar el club {nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (gestorClubes.EliminarClub(nombre))
                    {
                        ActualizarLista();
                        MessageBox.Show("Club eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar, el club tiene equipos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un club de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClubes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
