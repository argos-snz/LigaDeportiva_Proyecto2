using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaDeportiva.Interfaces;
using System.IO;

namespace LigaDeportiva.Clases
{
    public class GestorClubes : IExportable
    {
        private List<Club> clubes;

        /// <summary>
        /// Constructor de GestorClubes. Inicializa la lista interna vacía.
        /// </summary>
        public GestorClubes()
        {
            clubes = new List<Club>();
        }

        /// PRIMER CAMBIO (mejora si escriben River, river o RIVER)
        /// <summary>
        /// busca un club por nombre
        /// la busqueda no distinge entre mayusculas y minusculas
        /// </summary>
        /// <param name="nombre">Nombre del club a buscar</param>
        /// <returns>El club encontrado o null si no existe</returns>
        public Club BuscarClub(string nombre)
        {
            // validamos en nombre recibido
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return null;
            }

            // recorremos la lista buscando el club sin importar
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
        /// Agrega un nuevo club validando que el nombre no esté vacío ni repetido.
        /// </summary>
        /// <param name="nombre">Nombre del club a registrar</param>
        /// <returns>true si se agregó correctamente, false si el nombre está vacío o ya existe</returns>
        public bool AgregarClub(string nombre)
        {
            // SEGUNDO CAMBIO (si escriben "", "   ", null)
            // validamos que el nombre no sea nulo, vacio o con espacios
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            // eliminamos espacios al principio y al final
            nombre = nombre.Trim();

            // verificamos que no exista otro club con el mismo nombre.
            if (BuscarClub(nombre) != null)
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
            // TERCER CAMBIO (no cambia el funcionamiento, pero evitamos cosas como gestor.MostrarClubes().Clear();)
            // devolvemos una copia de la lista para evitar que otras clases modifiquen la colección directamente
            return new List<Club>(clubes);
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

            // un club no puede eliminarse si todavia posee equipos asociados
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
