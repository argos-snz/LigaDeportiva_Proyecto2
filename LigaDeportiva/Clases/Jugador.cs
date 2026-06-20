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
        /// Dni del jugador. Validación para el DNI.
        /// </summary>
        public int Dni
        {
            get { return dni; }
            set
            {
                if (value >= 10000000 && value <= 99999999)
                {
                    dni = value;
                }
                
            }
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



        /// <summary>
        /// Edad del jugador. Debe estar entre 3 y 85 años.
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 3 && value <= 85)
                    edad = value;
            }
        }


        /// <summary>
        /// Indica si el jugador tiene seguro activo.
        /// </summary>
        public bool Seguro
        {
            get { return seguro; }
            set { seguro = value; }
        }


        /// <summary>
        /// Indica si el jugador está afiliado.
        /// </summary>
        public bool Afiliado
        {
            get { return afiliado; }
            set { afiliado = value; }
        }
    }
}
