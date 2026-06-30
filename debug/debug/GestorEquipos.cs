using LigaDeportiva.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LigaDeportiva.Interfaces;

namespace LigaDeportiva.Clases
{
    public class GestorEquipos : IExportable
    {
        private List<Equipo> equipos;

        /// <summary>
        /// Constructor de GestorEquipos. Inicializa la lista vacía.
        /// </summary>
        public GestorEquipos()
        {
            equipos = new List<Equipo>();
        }


        // NOTA DEL DISEÑO: La modificación de equipos no está implementada
        // porque el nombre del equipo se genera automáticamente a partir del
        // club y la categoría y estos datos no pueden cambiar una vez creado
        // el equipo. Para "modificar" un equipo, se debe eliminar y crear uno nuevo.
        //----------------------------------------------------------------------------------


        /// <summary>
        /// Agrega un nuevo equipo a la lista.
        /// </summary>
        /// <param name="club">Club al que pertenece el equipo</param>
        /// <param name="categoria">Categoría del equipo</param>
        public void AgregarEquipo(Club club, Categoria categoria)
        {
            // PRIMER CAMBIO (validaciones)
            // validamos que el club exista
            if (club == null)
            {
                return;
            }

            // verificamos que el club no tenga ya un equipo de la misma categoria
            foreach (Equipo equipo in equipos)
            {
                if (equipo.Club == club && equipo.Categoria == categoria)
                {
                    return;
                }
            }

            Equipo nuevoEquipo = new Equipo(club, categoria);

            equipos.Add(nuevoEquipo);
            club.Equipos.Add(nuevoEquipo);
        }


        /// <summary>
        /// Busca un equipo por su nombre y lo elimina, si no tiene jugadores asignados.
        /// </summary>
        /// <param name="nombre">Nombre del equipo a eliminar</param>
        /// <returns>true si se eliminó correctamente, false si no se encontró o si tiene jugadores</returns>
        public bool EliminarEquipo(string nombre)
        {
            foreach (Equipo e in equipos)
            {
                // SEGUNDO CAMBIO (comparamos los nombres sin distinguir mayusculas y minusculas)
                if (e.Nombre.Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // si el equipo tiene jugadores, no se puede eliminar
                    if (e.Jugadores.Count > 0)
                    {
                        return false;
                    }

                    // se elimina de la lista de equipos
                    equipos.Remove(e);

                    // se elimina de la lista del club al que pertenecía
                    e.Club.Equipos.Remove(e);

                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Devuelve la lista completa de equipos registrados.
        /// </summary>
        /// <returns>Lista de todos los equipos</returns>
        public List<Equipo> MostrarEquipos()
        {
            // devolvemos una copia de la lista para evitar modificaciones externas
            return new List<Equipo>(equipos);
        }


        /// <summary>
        /// Devuelve la lista de equipos que pertenecen a un club específico.
        /// </summary>
        /// <param name="club">Club del que se quieren ver los equipos</param>
        /// <returns>Lista de equipos del club indicado</returns>
        public List<Equipo> EquiposPorClub(Club club)
        {
            List<Equipo> resultado = new List<Equipo>();
            foreach (Equipo e in equipos)
            {
                if (e.Club == club)
                {
                    resultado.Add(e);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Exporta la lista completa de equipos registrados y sus datos principales a un archivo de texto.
        /// </summary>
        /// <param name="rutaArchivo">Ruta donde se creará o sobrescribirá el archivo .txt</param>
        /// <returns>true si la exportación fue exitosa, false si ocurrió un error</returns>
        public bool ExportarDatosTxt(string rutaArchivo)
        {
            try
            {
                string contenido = "=== LISTADO DE EQUIPOS ===" + "\n";

                foreach (Equipo e in equipos)
                {
                    contenido += "Equipo: " + e.Nombre + "\n";
                    contenido += "Club: " + e.Club.Nombre + "\n";
                    contenido += "Categoría: " + e.Categoria + "\n";
                    contenido += "Cantidad de jugadores asignados: " + e.Jugadores.Count + "\n";
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


        /// <summary>
        /// Devuelve la lista de equipos que pertenecen a una categoría específica.
        /// </summary>
        public List<Equipo> EquiposPorCategoria(Categoria categoria)
        {
            List<Equipo> resultado = new List<Equipo>();
            foreach (Equipo e in equipos)
            {
                if (e.Categoria == categoria)
                {
                    resultado.Add(e);
                }
            }
            return resultado;
        }


    }
}
