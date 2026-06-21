using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaDeportiva.Enums;

namespace LigaDeportiva.Clases
{
    internal class Equipo
    {
        private string nombre;       // se arma automático: Club + Categoría + Letra
        private Categoria categoria;
        private Club club;           // referencia al objeto Club
        private List<Jugador> jugadores;


        /// <summary>
        /// Constructor de Equipo. Genera automáticamente el nombre combinando 
        /// el nombre del club, la categoría y una letra distintiva (A, B, C...) 
        /// según la cantidad de equipos que ya tiene el club.
        /// </summary>
        /// <param name="club">Club al que pertenece el equipo</param>
        /// <param name="categoria">Categoría del equipo</param>
        public Equipo(Club club, Categoria categoria)
        {
            this.club = club;
            this.categoria = categoria;
            jugadores = new List<Jugador>();

            char letra = (char)('A' + club.Equipos.Count);
            nombre = $"{club.Nombre} {categoria} {letra}";
        }


        /// <summary>
        /// Nombre del equipo. Se genera automáticamente a partir del club, la categoría y una letra.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
        }


        /// <summary>
        /// Categoría del equipo.
        /// </summary>
        public Categoria Categoria
        {
            get { return categoria; }
        }


        /// <summary>
        /// Club al que pertenece el equipo. No puede modificarse una vez creado el equipo.
        /// </summary>
        public Club Club
        {
            get { return club; }
        }


        /// <summary>
        /// Lista de jugadores que pertenecen a este equipo.
        /// </summary>
        public List<Jugador> Jugadores
        {
            get { return jugadores; }
        }

    }



}
