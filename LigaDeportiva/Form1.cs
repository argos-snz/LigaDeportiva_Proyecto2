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
    public partial class Form1 : Form
    {

        private GestorJugadores gestorJugadores;
        private GestorEquipos gestorEquipos;
        private GestorClubes gestorClubes;
        private GestorPartidos gestorPartidos;

        public Form1()
        {
            InitializeComponent();

            // inicializamos los gestores y cargamos los datos de prueba
            gestorJugadores = new GestorJugadores();
            gestorEquipos = new GestorEquipos();
            gestorClubes = new GestorClubes();
            gestorPartidos = new GestorPartidos();

            PrecargaDatos.Cargar(gestorPartidos, gestorJugadores, gestorClubes, gestorEquipos);
        }
                  
        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FormJugadores ventanaJugadores = new FormJugadores(gestorJugadores, gestorEquipos);
            ventanaJugadores.ShowDialog();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana equipos
            FormEquipos ventanaEquipos = new FormEquipos(gestorClubes, gestorEquipos);
            ventanaEquipos.ShowDialog();
        }

        private void btnClubes_Click(object sender, EventArgs e)
        {
            FormClubes ventanaClubes = new FormClubes(gestorClubes);
            ventanaClubes.ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            FormPartido ventanaPartidos = new FormPartido(gestorPartidos, gestorEquipos);
            ventanaPartidos.ShowDialog();
        }
    }
}
