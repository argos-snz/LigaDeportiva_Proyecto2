using LigaDeportiva.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    /// <summary>
    /// Representa un partido entre dos equipos de la misma categoría.
    /// </summary>
    internal class Partido
    {
        private Categoria categoria;
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private List<Jugador> titularesLocal;
        private List<Jugador> titularesVisitante;
        private List<Jugador> suplentesLocal;
        private List<Jugador> suplentesVisitante;
        private DateTime fechaHorario;
        private string lugar;
        private int golesLocal;
        private int golesVisitante;

        /// <summary>
        /// Constructor de Partido. Registra todos los datos del partido y las formaciones
        /// </summary>
        public Partido(Categoria categoria, Equipo equipoLocal, Equipo equipoVisitante,
                       List<Jugador> titularesLocal, List<Jugador> suplentesLocal,
                       List<Jugador> titularesVisitante, List<Jugador> suplentesVisitante,
                       DateTime fechaHorario, string lugar, int golesLocal, int golesVisitante)

        {
            this.categoria = categoria;
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
            this.titularesLocal = titularesLocal;
            this.titularesVisitante = titularesVisitante;
            this.fechaHorario = fechaHorario;
            this.lugar = lugar;
            this.golesLocal = golesLocal;
            this.golesVisitante = golesVisitante;

            // si me pasaron una lista de suplentes, la uso y, si me pasaron null sin suplentes, creo una lista vacía.
            if (suplentesLocal != null)
                this.suplentesLocal = suplentesLocal;
            else
                this.suplentesLocal = new List<Jugador>();

            if (suplentesVisitante != null)
                this.suplentesVisitante = suplentesVisitante;
            else
                this.suplentesVisitante = new List<Jugador>();
        }

        /// <summary>
        /// Categoría del encuentro.
        /// </summary>
        public Categoria Categoria
        {
            get { return categoria; }
        }

        /// <summary>
        /// Equipo que jugó de local.
        /// </summary>
        public Equipo EquipoLocal
        {
            get { return equipoLocal; }
        }

        /// <summary>
        /// Equipo que jugó de visitante.
        /// </summary>
        public Equipo EquipoVisitante
        {
            get { return equipoVisitante; }
        }

        /// <summary>
        /// Lista de los 5 jugadores titulares del equipo local.
        /// </summary>
        public List<Jugador> TitularesLocal
        {
            get { return titularesLocal; }
        }

        /// <summary>
        /// Lista de los jugadores suplentes del equipo local.
        /// </summary>
        public List<Jugador> SuplentesLocal
        {
            get { return suplentesLocal; }
        }

        /// <summary>
        /// Lista de los 5 jugadores titulares del equipo visitante.
        /// </summary>
        public List<Jugador> TitularesVisitante
        {
            get { return titularesVisitante; }
        }

        /// <summary>
        /// Lista de los jugadores suplentes del equipo visitante.
        /// </summary>
        public List<Jugador> SuplentesVisitante
        {
            get { return suplentesVisitante; }
        }

        /// <summary>
        /// Fecha y hora en la que se jugó el partido.
        /// </summary>
        public DateTime FechaHorario
        {
            get { return fechaHorario; }
        }

        /// <summary>
        /// Lugar o establecimiento donde se jugó el partido.
        /// </summary>
        public string Lugar
        {
            get { return lugar; }
        }

        /// <summary>
        /// Cantidad de goles anotados por el equipo local.
        /// </summary>
        public int GolesLocal
        {
            get { return golesLocal; }
            set
            {
                if (value >= 0)
                {
                    golesLocal = value;
                }
            }
        }

        /// <summary>
        /// Cantidad de goles anotados por el equipo visitante.
        /// </summary>
        public int GolesVisitante
        {
            get { return golesVisitante; }
            set
            {
                if (value >= 0)
                {
                    golesVisitante = value;
                }
            }
        }

    }
}
