using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    internal class Club
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
                if (value.Trim() != "")
                    nombre = value;
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
