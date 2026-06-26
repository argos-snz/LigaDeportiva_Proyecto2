using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaDeportiva.Interfaces;
using System.IO;

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
        /// Busca un club por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del club a buscar</param>
        /// <returns>El club encontrado, o null si no existe</returns>
        public Club BuscarClub(string nombre)
        {
            foreach (Club c in clubes)
            {
                if (c.Nombre == nombre )
                {
                    return c;
                }
            }
            return null;
        }


        /// <summary>
        /// Agrega un nuevo club validando que el nombre no esté vacío ni repetido.
        /// </summary>
        /// <param name="nombre">Nombre del club a registrar</param>
        /// <returns>true si se agregó correctamente, false si el nombre está vacío o ya existe</returns>
        public bool AgregarClub(string nombre)
        {
            if (nombre.Trim() == "" || BuscarClub(nombre) != null)
            {
                return false;
            }

            Club nuevoClub = new Club(nombre.Trim());
            clubes.Add(nuevoClub);
            return true;
        }

        /// <summary>
        /// Devuelve la lista completa de los clubes registrados.
        /// </summary>
        /// <returns>Lista de todos los clubes</returns>
        public List<Club> MostrarClubes()
        {
            return clubes;
        }


        /// <summary>
        /// Busca un club por su nombre y lo elimina, siempre que no tenga equiposs registrados.
        /// </summary>
        /// <param name="nombre">Nombre del club a eliminar</param>
        /// <returns>true si se eliminó correctamente, false si no se encontró o si tiene equipos</returns>
        public bool EliminarClub(string nombre)
        {
            Club c = BuscarClub(nombre);

            if (c == null)
            {
                return false;
            }
            if (c.Equipos.Count > 0)
            {
                return false;
            }

            clubes.Remove(c);
            return true;
        }

        /// <summary>
        /// Exporta la lista completa de clubes y la cantidad de equipos de cada uno a un archivo de texto.
        /// </summary>
        /// <param name="rutaArchivo">Ruta completa donde se creará o sobrescribirá el archivo .txt</param>
        /// <returns>true si la exportación fue exitosa, false si ocurrió un error</returns>
        public bool ExportarDatosTxt(string rutaArchivo)
        {
            try
            {
                string contenido = "=== LISTADO DE CLUBES ===" + "\n";

                foreach (Club c in clubes)
                {
                    contenido += "Nombre del Club: " + c.Nombre + "\n";
                    contenido += "Equipos registrados en este club: " + c.Equipos.Count + "\n";
                    contenido += "----------------------------" + "\n";
                }

                File.WriteAllText(rutaArchivo, contenido);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
