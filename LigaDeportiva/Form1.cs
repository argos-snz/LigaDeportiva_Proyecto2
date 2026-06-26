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

            PrecargaDatos.Cargar(gestorPartidos, gestorJugadores);
        }

          

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            FormJugadores ventanaJugadores = new FormJugadores(gestorJugadores, gestorEquipos);
            ventanaJugadores.ShowDialog();
        }
    }
}
