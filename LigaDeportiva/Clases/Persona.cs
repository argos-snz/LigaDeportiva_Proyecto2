using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    /// <summary>
    /// Clase base ABSTRACTA que representa a una persona genérica en el sistema.
    /// En un futuro, se podrían crear mas clases derivadas además de Jugador, 
    /// como Entrenador, Arbitro, etc., que hereden de Persona.
    /// </summary>
    internal abstract class Persona
    {
        private int dni; 
        private string nombre;
        private string apellido;
        private int edad;

        /// <summary>
        /// Constructor de la clase abstracta Persona.
        /// </summary>
        public Persona(int dni, string nombre, string apellido, int edad)
        {
            // usamos las propiedades en mayúscula para que al crear la persona, pase por las validaciones
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        /// <summary>
        /// Dni de la persona. Validación para el DNI de 8 dígitos.
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
        /// Nombre de la persona. No permite espacios en blanco.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim() != "")
                    nombre = value;
            }
        }

        /// <summary>
        /// Apellido de la persona. No permite espacios en blanco.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value.Trim() != "")
                    apellido = value;
            }
        }

        /// <summary>
        /// Edad de la persona. Debe estar entre 3 y 85 años.
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
    }
}
