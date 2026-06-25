using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Clases
{
    internal class GestorClubes
    {
        private List<Club> clubes;

        /// <summary>
        /// Constructor de GestorClubes. Inicializa la lista interna vacía.
        /// </summary>
        public GestorClubes()
        {
            clubes = new List<Club>();
        }


        /// <summary>
        /// Agrega un nuevo club al sistema validando que el nombre no esté repetido.
        /// </summary>
        /// <param name="nombre">Nombre del club a registrar</param>
        /// <returns>true si se agregó correctamente, false si el club ya existía o el nombre es inválido</returns>
        public bool AgregarClub(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || BuscarClub(nombre) != null)
            {
                return false;
            }

            Club nuevoClub = new Club(nombre.Trim());
            clubes.Add(nuevoClub);
            return true;
        }

        /// <summary>
        /// Busca un club registrado a partir de su nombre, ignorando mayúsculas y minúsculas.
        /// </summary>
        /// <param name="nombre">Nombre del club a buscar.</param>
        /// <returns>El objeto Club encontrado, o null si no existe ningún club con ese nombre.</returns>
        public Club BuscarClub(string nombre)
        {
            foreach (Club c in clubes)
            {
                if (c.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        /// <summary>
        /// Devuelve la lista completa de los clubes registrados.
        /// </summary>
        /// <returns>Lista de objetos de tipo Club.</returns>
        public List<Club> MostrarClubes()
        {
            return clubes;
        }
    }
}
