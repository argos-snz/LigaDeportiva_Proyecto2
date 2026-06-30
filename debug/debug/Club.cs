using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    public class Club
    {
        private string nombre;
        private List<Equipo> equipos;

        /// <summary>
        /// Constructor de Club. Crea un nuevo club con su nombre y una lista vacía de equipos.
        /// </summary>
        /// <param name="nombre">Nombre del club</param>
        public Club(string nombre)
        {
            Nombre = nombre;
            equipos = new List<Equipo>();
        }


        /// <summary>
        /// Nombre del club. No permite espacios vacíos.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                // PRIMER CAMBIO (validamos que el nombre recibido no sea nulo o tenga espacios en blanco)
                if (!string.IsNullOrWhiteSpace(value))
                {
                    // Guardamos el nombre sin espacios al inicio o al final.
                    nombre = value.Trim();
                }
            }
        }


        /// <summary>
        /// Lista de equipos que pertenecen a este club.
        /// </summary>
        public List<Equipo> Equipos
        {
            get { return equipos; }
        }

    }
}
