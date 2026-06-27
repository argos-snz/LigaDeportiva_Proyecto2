using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaDeportiva.Enums;

namespace LigaDeportiva.Clases
{
    /// <summary>
    /// Clase ESTÁTICA que nos provee datos iniciales de prueba para el sistema.
    /// </summary>
    public static class PrecargaDatos
    {
        /// <summary>
        /// Carga equipos, jugadores y un partido de prueba 
        /// </summary>
        public static void Cargar(GestorPartidos gestorPartidos, GestorJugadores gestorJugadores, GestorClubes gestorClubes, GestorEquipos gestorEquipos)
        {
            //cargamoss y los guardamos en el gestor de clubes
            gestorClubes.AgregarClub("River");
            gestorClubes.AgregarClub("Boca");

            // cargamos equipos y los guardamos en el gestor de equipos
            Club clubA = gestorClubes.BuscarClub("River");
            Club clubB = gestorClubes.BuscarClub("Boca");

            gestorEquipos.AgregarEquipo(clubA, Categoria.Primera);
            gestorEquipos.AgregarEquipo(clubB, Categoria.Primera);

            // Creamos los 5 jugadores titulares de River
            Jugador jA1 = new Jugador(11111111, "Roberto", "Ruso", 25, true, true);
            Jugador jA2 = new Jugador(22222222, "Carlos", "Gomez", 28, true, true);
            Jugador jA3 = new Jugador(33333333, "Luis", "Fuego", 22, true, true);
            Jugador jA4 = new Jugador(44444444, "Martin", "Perez", 30, true, true);
            Jugador jA5 = new Jugador(55555555, "Diego", "Lopez", 26, true, true);

            // Creamos los 5 jugadores titulares de Boca
            Jugador jB1 = new Jugador(66666666, "Juan", "Gordo", 29, true, true);
            Jugador jB2 = new Jugador(77777777, "Pedro", "Gorda", 24, true, true);
            Jugador jB3 = new Jugador(88888888, "Matias", "Diaz", 27, true, true);
            Jugador jB4 = new Jugador(99999999, "Lucas", "Sosa", 21, true, true);
            Jugador jB5 = new Jugador(12345678, "Tomas", "Ruiz", 23, true, true);

            // Agregamos los jugadores al gestor de jugadores
            gestorJugadores.AgregarJugador(11111111, "Roberto", "Ruso", 25, true, true);
            gestorJugadores.AgregarJugador(22222222, "Carlos", "Gomez", 28, true, true);
            gestorJugadores.AgregarJugador(33333333, "Luis", "Fuego", 22, true, true);
            gestorJugadores.AgregarJugador(44444444, "Martin", "Perez", 30, true, true);
            gestorJugadores.AgregarJugador(55555555, "Diego", "Lopez", 26, true, true);
            gestorJugadores.AgregarJugador(66666666, "Juan", "Gordo", 29, true, true);
            gestorJugadores.AgregarJugador(77777777, "Pedro", "Gorda", 24, true, true);
            gestorJugadores.AgregarJugador(88888888, "Matias", "Diaz", 27, true, true);
            gestorJugadores.AgregarJugador(99999999, "Lucas", "Sosa", 21, true, true);
            gestorJugadores.AgregarJugador(12345678, "Tomas", "Ruiz", 23, true, true);

            //Listas de jugadores
            List<Jugador> titularesA = new List<Jugador>();
            titularesA.Add(jA1); 
            titularesA.Add(jA2); 
            titularesA.Add(jA3); 
            titularesA.Add(jA4); 
            titularesA.Add(jA5);

            List<Jugador> titularesB = new List<Jugador>();
            titularesB.Add(jB1); 
            titularesB.Add(jB2); 
            titularesB.Add(jB3); 
            titularesB.Add(jB4); 
            titularesB.Add(jB5);

            List<Jugador> suplentesA = new List<Jugador>(); //no hay suplentes
            List<Jugador> suplentesB = new List<Jugador>();

            //buscamos los equipos en el gestor de equipos para poder crear el partido
            var listaEquipos = gestorEquipos.MostrarEquipos();

            Equipo equipoA = null;
            Equipo equipoB = null;

            foreach (Equipo e in listaEquipos)
            {
                if (e.Club.Nombre == "River")
                {
                    equipoA = e;
                }
                if (e.Club.Nombre == "Boca")
                {
                    equipoB = e;
                }
            }

            //Creamos el partido usando TU constructor gigante y seguro
            Partido partidoPrueba = new Partido(
                Categoria.Primera,        // categoría
                equipoA,                  // equipoLocal
                equipoB,                  // equipoVisitante
                titularesA,               // titularesLocal
                suplentesA,               // suplentesLocal
                titularesB,               // titularesVisitante
                suplentesB,               // suplentesVisitante
                DateTime.Now.AddDays(-2), // fechaHorario
                "Polideportivo Bahía",    // lugar
                3,                        // golesLocal
                1                         // golesVisitante
            );

            // Guardamos el partido
            gestorPartidos.AgregarPartido(partidoPrueba);

        }
    }
}
