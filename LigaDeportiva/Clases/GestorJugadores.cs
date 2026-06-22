using LigaDeportiva.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    internal class GestorJugadores
    {
        private List<Jugador> jugadores;

        /// <summary>
        /// Constructor. Inicializa la lista vacía.
        /// </summary>
        public GestorJugadores()
        {
            jugadores = new List<Jugador>();
        }


        /// <summary>
        /// agrega un nuevo jugador a la lista validando que el DNI no esté repetido.
        /// </summary>
        /// <returns>true si se agregó correctamente, false si el DNI ya existía</returns>
        public bool AgregarJugador(int dni, string nombre, string apellido, int edad, bool seguro, bool afiliado)
        {
            if (ExisteDni(dni))
            {
                return false;
            }
            else
            {
                Jugador nuevoJugador = new Jugador(dni, nombre, apellido, edad, seguro, afiliado);
                jugadores.Add(nuevoJugador);
                return true;
            }

        }


        /// <summary>
        /// Verifica si ya existe un jugador registrado con el DNI indicado.
        /// </summary>
        /// <param name="dni">DNI a buscar</param>
        /// <returns>true si ya existe un jugador con ese DNI, false en caso contrario</returns>
        public bool ExisteDni(int dni)
        {
            foreach (Jugador j in jugadores)
            {
                if (j.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Busca un jugador por su DNI y lo elimina de la lista y equipos a los q pertenece.
        /// </summary>
        /// <param name="dni">DNI del jugador a eliminar</param>
        /// <returns>true si se eliminó correctamente, false si no se encontró ningún jugador con ese DNI</returns>
        public bool EliminarJugador(int dni)
        {
            foreach (Jugador j in jugadores)
            {
                if (j.Dni == dni)
                {   
                    // primero sacamos al jugador de cada equipo al q pertenece
                    foreach (Equipo e in j.Equipos)
                    {
                        e.Jugadores.Remove(j);
                    }


                    jugadores.Remove(j);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Devuelve la lista completa de jugadores registrados.
        /// </summary>
        /// <returns>Lista de todos los jugadores</returns>
        public List<Jugador> MostrarJugadores()
        {
            return jugadores;
        }


        public bool AsignarJugadorAEquipo(Jugador jugador, Equipo equipo)
        {
            // Valida edad por categoría
            bool edadCorrecta = false;

            switch (equipo.Categoria)
            {
                case Categoria.Infantiles:
                    if (jugador.Edad < 13) edadCorrecta = true;
                    break;
                case Categoria.Cadetes:
                    if (jugador.Edad >= 13 && jugador.Edad < 16) edadCorrecta = true;
                    break;
                case Categoria.Juveniles:
                    if (jugador.Edad >= 16 && jugador.Edad < 18) edadCorrecta = true;
                    break;
                case Categoria.Primera:
                    if (jugador.Edad >= 18) edadCorrecta = true;
                    break;
                case Categoria.Veteranos:
                    if (jugador.Edad > 35) edadCorrecta = true;
                    break;
            }

            if (!edadCorrecta)
            {
                return false;
            }


            // Valida que no esté ya en ese equipo
            bool yaPertenece = false;
            foreach (Equipo e in jugador.Equipos)
            {
                if (e.Nombre == equipo.Nombre)
                {
                    yaPertenece = true;
                }
            }

            if (yaPertenece)
            {
                return false;
            }

            jugador.Equipos.Add(equipo);
            equipo.Jugadores.Add(jugador);

            return true;

        }


        /// <summary>
        /// elimina un jugador de un equipo, sin eliminarlo del sistema general.
        /// </summary>
        /// <param name="jugador">Jugador a quitar del equipo</param>
        /// <param name="equipo">Equipo del cual se quiere quitar al jugador</param>
        /// <returns>true si se elimino correctamente, false si el jugador no pertenecía a ese equipo</returns>
        public bool QuitarJugadorDeEquipo(Jugador jugador, Equipo equipo)
        {
            if (jugador.Equipos.Contains(equipo))
            {
                jugador.Equipos.Remove(equipo);
                equipo.Jugadores.Remove(jugador);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Busca un jugador por su DNI.
        /// </summary>
        /// <param name="dni">DNI del jugador a buscar</param>
        /// <returns>El jugador encontrado, o null si no existe ninguno con ese DNI</returns>
        public Jugador BuscarJugador(int dni)
        {
            foreach (Jugador j in jugadores)
            {
                if (j.Dni == dni)
                {
                    return j;
                }
            }
            return null;
        }


        /// <summary>
        /// Modifica los datos de un jugador, se busca mediante su DNI.
        /// </summary>
        /// <param name="dni">DNI del jugador a modificar</param>
        /// <param name="nuevoNombre">Nuevo nombre</param>
        /// <param name="nuevoApellido">Nuevo apellido</param>
        /// <param name="nuevaEdad">Nueva edad</param>
        /// <param name="nuevoSeguro">Nuevo valor de seguro</param>
        /// <param name="nuevoAfiliado">Nuevo valor de afiliado</param>
        /// <returns>true si se modificó correctamente, false si no se encontró el jugador</returns>
        public bool ModificarJugador(int dni, string nuevoNombre, string nuevoApellido, int nuevaEdad, bool nuevoSeguro, bool nuevoAfiliado)
        {
            Jugador j = BuscarJugador(dni);

            if (j == null)
            {
                return false;
            }

            j.Nombre = nuevoNombre;
            j.Apellido = nuevoApellido;
            j.Edad = nuevaEdad;
            j.Seguro = nuevoSeguro;
            j.Afiliado = nuevoAfiliado;

            return true;
        }
    }
}
