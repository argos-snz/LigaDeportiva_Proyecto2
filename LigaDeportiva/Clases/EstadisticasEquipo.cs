using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    /// <summary>
    /// Guarda y calcula las estadísticas de un equipo en base a su historial de partidos.
    /// </summary>
    public class EstadisticasEquipo
    {
        private Equipo equipoAsociado;
        private int partidosJugados;
        private int partidosGanados;
        private int partidosEmpatados;
        private int partidosPerdidos;

        /// <summary>
        /// Equipo al cual le pertenecen estas estadísticas.
        /// </summary>
        public Equipo EquipoAsociado
        {
            get { return equipoAsociado; }
            set { equipoAsociado = value; }
        }

        /// <summary>
        /// Cantidad total de partidos que jugó el equipo.
        /// </summary>
        public int PartidosJugados
        {
            get { return partidosJugados; }
            set { partidosJugados = value; }
        }

        /// <summary>
        /// Cantidad de partidos en los que el equipo ganó.
        /// </summary>
        public int PartidosGanados
        {
            get { return partidosGanados; }
            set { partidosGanados = value; }
        }

        /// <summary>
        /// Cantidad de partidos en los que el equipo empató.
        /// </summary>
        public int PartidosEmpatados
        {
            get { return partidosEmpatados; }
            set { partidosEmpatados = value; }
        }

        /// <summary>
        /// Cantidad de partidos en los que el equipo perdió.
        /// </summary>
        public int PartidosPerdidos
        {
            get { return partidosPerdidos; }
            set { partidosPerdidos = value; }
        }

        /// <summary>
        /// Calcula y devuelve el total de puntos obtenidos por el equipo (3 por victoria, 1 por empate, 0 por derrota).
        /// </summary>
        public int Puntos
        {
            get { return (partidosGanados * 3) + (partidosEmpatados * 1); }
        }
    }
}