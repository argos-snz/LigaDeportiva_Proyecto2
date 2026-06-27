using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaDeportiva.Clases;

namespace LigaDeportiva
{
    public partial class FormJugadores : Form
    {
        private GestorJugadores gestorJugadores;
        private GestorEquipos gestorEquipos;

        public FormJugadores(GestorJugadores gestorJugadores, GestorEquipos gestorEquipos)
        {
            InitializeComponent();
            this.gestorJugadores = gestorJugadores;
            this.gestorEquipos = gestorEquipos;
        }


        // Evento Load: se ejecuta apenas se abre la ventana (Hacer doble clic en el fondo del formulario)
        private void FormJugadores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();

            // Esto hace que las columnas ocupen automáticamente todo el ancho disponible
            dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Actualiza la grilla
        private void ActualizarGrilla()
        {
            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = gestorJugadores.MostrarJugadores();
        }

        //vacía los TextBox después de agregar, modificar o eliminar
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            chkSeguro.Checked = false;
            chkAfiliado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                bool seguro = chkSeguro.Checked;
                bool afiliado = chkAfiliado.Checked;

                bool exito = gestorJugadores.AgregarJugador(dni, nombre, apellido, edad, seguro, afiliado);

                if (exito)
                {
                    MessageBox.Show("Jugador agregado con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar. Verifique que el DNI no esté repetido y que los datos sean válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI y la Edad deben ser valores numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                bool seguro = chkSeguro.Checked;
                bool afiliado = chkAfiliado.Checked;

                bool exito = gestorJugadores.ModificarJugador(dni, nombre, apellido, edad, seguro, afiliado);

                if (exito)
                {
                    MessageBox.Show("Datos del jugador modificados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un jugador con ese DNI para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI y la Edad deben ser valores numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento del Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(txtDni.Text);

                // Pedimos confirmación al usuario antes de borrar un registro
                DialogResult respuesta = MessageBox.Show($"¿Estás seguro de que querés eliminar al jugador con DNI {dni}?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool exito = gestorJugadores.EliminarJugador(dni);

                    if (exito)
                    {
                        MessageBox.Show("Jugador eliminado del sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un jugador con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un DNI numérico válido para poder eliminar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        
        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita crasheos si el usuario hace clic en los títulos de las columnas
            {
                DataGridViewRow filaSeleccionada = dgvJugadores.Rows[e.RowIndex];

                // Pasamos los datos de la fila a los TextBox de la pantalla
                txtDni.Text = filaSeleccionada.Cells["Dni"].Value?.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value?.ToString();
                txtEdad.Text = filaSeleccionada.Cells["Edad"].Value?.ToString();

                if (filaSeleccionada.Cells["Seguro"].Value != null)
                    chkSeguro.Checked = (bool)filaSeleccionada.Cells["Seguro"].Value;

                if (filaSeleccionada.Cells["Afiliado"].Value != null)
                    chkAfiliado.Checked = (bool)filaSeleccionada.Cells["Afiliado"].Value;
            }
        }
    }
}
