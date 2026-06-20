using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    internal class Jugador
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private bool seguro;
        private bool afiliado;


        /// <summary>
        /// Constructor de Jugador. 
        /// </summary>
        public Jugador(int dni, string nombre, string apellido, int edad, bool seguro, bool afiliado)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Seguro = seguro;
            Afiliado = afiliado;
        }


        /// <summary>
        /// Nombre del jugador. No permite espacios en blanco.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim() != "")  // el .Trim() saca los espacios en blanco al principio y al final del texto
                    nombre = value;
            }
        }


        /// <summary>
        /// Apellido del jugador. No permite espacios en blanco.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Trim() != "")  // el .Trim() saca los espacios en blanco al principio y al final del texto
                    apellido = value;
            }
        }
    }
}
