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
        private List<Equipo> equipos;


        /// <summary>
        /// Constructor de Jugador. Crea un nuevo jugador.
        /// Si algún dato ingresado no cumple las validaciones (del Dni, Edad, etc), 
        /// queda en 0.
        /// Para avisarle al usuario cuando salte un error por el control de
        /// errores se puede hacer después desde el formulario antes de llamar a este constructor.
        /// </summary>
        /// <param name="dni">      DNI del jugador (debe tener 8 dígitos)</param>
        /// <param name="nombre">   Nombre del jugador (no puede estar vacío)</param>
        /// <param name="apellido"> Apellido del jugador (no puede estar vacío)</param>
        /// <param name="edad">     Edad del jugador (debe estar entre 3 y 85 años)</param>
        /// <param name="seguro">   Indica si el jugador tiene seguro</param>
        /// <param name="afiliado"> Indica si el jugador está afiliado</param>
        public Jugador(int dni, string nombre, string apellido, int edad, bool seguro, bool afiliado)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Seguro = seguro;
            Afiliado = afiliado;
            equipos = new List<Equipo>();
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


        /// <summary>
        /// Lista de equipos a los que pertenece este jugador.
        /// </summary>
        public List<Equipo> Equipos
        {
            get { return equipos; }
        }
    }
}
