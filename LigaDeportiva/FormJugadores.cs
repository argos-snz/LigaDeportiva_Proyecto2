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
        private Jugador jugadorSeleccionado;

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

            // Cargamos los equipos en el ComboBox de filtro
            cmbCategorias.Items.Clear();
            cmbCategorias.Items.Add("-- Todos --");
            foreach (Equipo eq in gestorEquipos.MostrarEquipos())
            {
                cmbCategorias.Items.Add(eq);
            }
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.SelectedIndex = 0; // selecciona "--Todos--"

            dgvJugadores.SelectionChanged += dgvJugadores_SelectionChanged;

            dgvJugadores.SelectionChanged += dgvJugadores_SelectionChanged;
            dgvJugadores.CellDoubleClick += dgvJugadores_CellDoubleClick; 
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
            string dniTexto = txtDni.Text.Trim();
            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El N° de DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                bool seguro = chkSeguro.Checked;
                bool afiliado = chkAfiliado.Checked;


                if (dni < 10000000 || dni > 99999999)
                {
                    MessageBox.Show("El DNI debe estar entre 10.000.000 y 99.999.999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (edad < 3 || edad > 85)
                {
                    MessageBox.Show("La edad debe estar entre 3 y 85 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || !EsTextoValido(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) || !EsTextoValido(txtApellido.Text))
                {
                    MessageBox.Show("El nombre y el apellido son obligatorios y no pueden contener números, ni espacios vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            string dniTexto = txtDni.Text.Trim();
            if (txtDni.Text.Trim().Length != 8)
            {
                MessageBox.Show("El N° de DNI debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int dni = int.Parse(txtDni.Text);
                int edad = int.Parse(txtEdad.Text);
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                bool seguro = chkSeguro.Checked;
                bool afiliado = chkAfiliado.Checked;

                

                if (dni < 10000000 || dni > 99999999)
                {
                    MessageBox.Show("El N° de DNI debe estar entre 10000000 y 99999999.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (edad < 3 || edad > 85)
                {
                    MessageBox.Show("La edad debe estar entre 3 y 85 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || !EsTextoValido(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) || !EsTextoValido(txtApellido.Text))
                {
                    MessageBox.Show("El nombre y el apellido son obligatorios y no pueden contener números, ni espacios vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                MessageBox.Show("El DNI y la edad deben ser valores numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (dgvJugadores.SelectedRows.Count > 0)
                {
                    if (dgvJugadores.SelectedRows[0].DataBoundItem is Jugador j)
                    {
                        jugadorSeleccionado = j;
                    }
                }
                else
                {
                    //si no hay nada seleccionado limpiamos la variable
                    jugadorSeleccionado = null;
                }
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guardamos el nombre del jugador seleccionado antes de filtrar
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string edad = txtEdad.Text;

            if (cmbCategorias.SelectedItem is string) // seleccionó "-- Todos --"
            {
                ActualizarGrilla(); // muestra todos
            }
            else if (cmbCategorias.SelectedItem is Equipo equipoSeleccionado)
            {
                dgvJugadores.DataSource = null;
                dgvJugadores.DataSource = equipoSeleccionado.Jugadores;
                dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvJugadores.Columns["Equipos"] != null)
                    dgvJugadores.Columns["Equipos"].Visible = false;
            }

            // Restauramos los datos en los textbox para no perder la selección del jugador al filtrar
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDni.Text = dni;
            txtEdad.Text = edad;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarDeEquipo_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un jugador de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cmbCategorias.SelectedItem is Equipo equipoSeleccionado))
            {
                MessageBox.Show("Seleccioná un equipo de la lista para quitar al jugador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvJugadores.SelectedRows[0].DataBoundItem is Jugador jugador)
            {
                DialogResult respuesta = MessageBox.Show(
                    $"¿Quitar a {jugador.Nombre} {jugador.Apellido} del equipo {equipoSeleccionado.Nombre}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (gestorJugadores.QuitarJugadorDeEquipo(jugador, equipoSeleccionado))
                    {
                        MessageBox.Show("Jugador quitado del equipo correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvJugadores.DataSource = null;
                        dgvJugadores.DataSource = equipoSeleccionado.Jugadores;
                        dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("El jugador no pertenece a ese equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAsignarAEquipo_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un jugador de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cmbCategorias.SelectedItem is Equipo equipoDestino))
            {
                MessageBox.Show("Seleccioná un equipo del combo para asignar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscamos los objetos reales por DNI y nombre
            Jugador jugadorReal = gestorJugadores.BuscarJugador(jugadorSeleccionado.Dni);
            Equipo equipoReal = gestorEquipos.BuscarEquipo(equipoDestino.Nombre);

            if (jugadorReal == null || equipoReal == null)
            {
                MessageBox.Show("No se encontró el jugador o el equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validamos que no esté ya en ese equipo
            foreach (Equipo eq in jugadorReal.Equipos)
            {
                if (eq.Nombre == equipoReal.Nombre)
                {
                    MessageBox.Show("El jugador ya pertenece a ese equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validamos que no esté en otro equipo de la misma categoría
            foreach (Equipo eq in jugadorReal.Equipos)
            {
                if (eq.Categoria == equipoReal.Categoria)
                {
                    MessageBox.Show("El jugador ya pertenece a un equipo de la misma categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validamos límite de jugadores
            if (equipoReal.Jugadores.Count >= 8)
            {
                MessageBox.Show("El equipo ya tiene el máximo de 8 jugadores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exito = gestorJugadores.AsignarJugadorAEquipo(jugadorReal, equipoReal);

            if (exito)
            {
                MessageBox.Show($"{jugadorReal.Nombre} {jugadorReal.Apellido} fue asignado a {equipoReal.Nombre}.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
                jugadorSeleccionado = null;
            }
            else
            {
                MessageBox.Show(
                   $"No se pudo asignar. La edad del jugador no corresponde a la categoría {equipoReal.Categoria}.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count == 0) return;

            if (dgvJugadores.SelectedRows.Count > 0 &&
                dgvJugadores.SelectedRows[0].DataBoundItem is Jugador j)
            {
                jugadorSeleccionado = j;
                                    
                txtDni.Text = j.Dni.ToString();
                txtNombre.Text = j.Nombre;
                txtApellido.Text = j.Apellido;
                txtEdad.Text = j.Edad.ToString();
                chkSeguro.Checked = j.Seguro;
                chkAfiliado.Checked = j.Afiliado;
            }
        }

        private void dgvJugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool EsTextoValido(string texto)
        {
            foreach (char c in texto)
            {
                
                if (char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
