using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    /// <summary>
    /// Representa a un jugador inscripto en la liga, heredando los datos básicos dedsde Persona.
    /// </summary>
    public class Jugador : Persona
    {
        private bool seguro;
        private bool afiliado;
        private List<Equipo> equipos;



        /// <summary>
        /// Constructor de Jugador 
        /// </summary>
        public Jugador(int dni, string nombre, string apellido, int edad, bool seguro, bool afiliado) : base(dni, nombre, apellido, edad) 
        {
            this.seguro = seguro;
            this.afiliado = afiliado;
            this.equipos = new List<Equipo>();
        }
            

        /// <summary>
        /// Indica si el jugador tiene seguro.
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
