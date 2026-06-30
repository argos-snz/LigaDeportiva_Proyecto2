using LigaDeportiva.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LigaDeportiva.Interfaces;
using System.IO;

namespace LigaDeportiva.Clases
{
    public class GestorPartidos : IExportable
    {
        private List<Partido> partidos;

        /// <summary>
        /// Constructor de GestorPartidos. Inicializa una lista vacía.
        /// </summary>
        public GestorPartidos()
        {
            partidos = new List<Partido>();
        }

        /// <summary>
        /// Agrega un nuevo partido a la lista de partidos.
        /// </summary>
        /// <param name="partido">Objeto Partido con los datos del encuentro</param>
        /// <returns>true si se agregó correctamente</returns>
        public bool AgregarPartido(Partido partido)
        {
            // PRIMER CAMBIO (verificamos que el partido recibido sea valido)
            if (partido == null)
            {
                return false;
            }

            partidos.Add(partido);
            return true;
        }

        /// <summary>
        /// Devuelve la lista completa de partidos disputadosjugados.
        /// </summary>
        /// <returns>Lista de todos los partidos registrados</returns>
        public List<Partido> MostrarPartidos()
        {
            // SEGUNDO CAMBIO (devolvemos una copia de la lista)
            return new List<Partido>(partidos);
        }

        /// <summary>
        /// Devuelve todos los partidos en los que jugó un equipo, ya sea como local o visitante.
        /// </summary>
        /// <param name="equipo">Equipo del que se quieren ver los partidos</param>
        /// <returns>Lista de partidos en los que participó el equipo</returns>
        public List<Partido> PartidosPorEquipo(Equipo equipo)
        {
            List<Partido> resultado = new List<Partido>();
            foreach (Partido p in partidos)
            {
                if (p.EquipoLocal == equipo || p.EquipoVisitante == equipo)
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Devuelve todos los partidos jugados en una categoría específica.
        /// </summary>
        /// <param name="categoria">Categoría por la que se quiere filtrar</param>
        /// <returns>Lista de partidos de esa categoría</returns>
        public List<Partido> PartidosPorCategoria(Categoria categoria)
        {
            List<Partido> resultado = new List<Partido>();
            foreach (Partido p in partidos)
            {
                if (p.Categoria == categoria)
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }

        /// <summary>
        /// Procesa el historial de partidos y calcula las estadísticas de una lista de equipos.
        /// </summary>
        /// <param name="equipos">Lista de equipos a evaluar</param>
        /// <returns>Lista de objetos EstadisticasEquipo con los cálculos terminados</returns>
        public List<EstadisticasEquipo> CalcularEstadisticas(List<Equipo> equipos)
        {
            List<EstadisticasEquipo> resultados = new List<EstadisticasEquipo>();

            foreach (Equipo equipo in equipos)
            {
                EstadisticasEquipo stat = new EstadisticasEquipo();
                stat.EquipoAsociado = equipo;

                foreach (Partido p in partidos)
                {
                    if (p.EquipoLocal == equipo)
                    {
                        stat.PartidosJugados++;
                        if (p.GolesLocal > p.GolesVisitante) stat.PartidosGanados++;
                        else if (p.GolesLocal == p.GolesVisitante) stat.PartidosEmpatados++;
                        else stat.PartidosPerdidos++;
                    }
                    else if (p.EquipoVisitante == equipo)
                    {
                        stat.PartidosJugados++;
                        if (p.GolesVisitante > p.GolesLocal) stat.PartidosGanados++;
                        else if (p.GolesVisitante == p.GolesLocal) stat.PartidosEmpatados++;
                        else stat.PartidosPerdidos++;
                    }
                }
                resultados.Add(stat);
            }
            return resultados;
        }

        /// <summary>
        /// Genera y exporta la tabla de posiciones a un archivo de texto utilizando las estadísticas calculadas.
        /// </summary>
        /// <param name="rutaArchivo">Ruta completa del archivo .txt a generar</param>
        /// <param name="equipos">Lista de equipos de una categoría a evaluar</param>
        /// <returns>true si se exportó correctamente, false en caso de error</returns>
        public bool ExportarEstadisticasTxt(string rutaArchivo, List<Equipo> equipos)
        {
            try
            {
                // TERCER CAMBIO (verificamos que la lista de equipos exista y tenga elementos)
                if (equipos == null || equipos.Count == 0)
                {
                    return false;
                }

                // Llamamos al método que hace los cálculos
                List<EstadisticasEquipo> stats = CalcularEstadisticas(equipos);

                string contenido = "=== TABLA DE POSICIONES Y ESTADÍSTICAS ===\n\n";

                int maxVictorias = -1;
                int maxDerrotas = -1;
                Equipo equipoMasVictorias = null;
                Equipo equipoMasDerrotas = null;

                // texto del reporte recorriendo la lista calculada
                foreach (EstadisticasEquipo s in stats)
                {
                    // encontrar al de más victorias y derrotas
                    if (s.PartidosGanados > maxVictorias)
                    {
                        maxVictorias = s.PartidosGanados;
                        equipoMasVictorias = s.EquipoAsociado;
                    }
                    if (s.PartidosPerdidos > maxDerrotas)
                    {
                        maxDerrotas = s.PartidosPerdidos;
                        equipoMasDerrotas = s.EquipoAsociado;
                    }

                    contenido += "Equipo: " + s.EquipoAsociado.Nombre + "\n";
                    contenido += "Puntos: " + s.Puntos + " | PJ: " + s.PartidosJugados + " | PG: " + s.PartidosGanados + " | PE: " + s.PartidosEmpatados + " | PP: " + s.PartidosPerdidos + "\n";
                    contenido += "----------------------------------------\n";
                }

                contenido += "\n=== RESUMEN ESTADÍSTICO ===\n";
                if (equipoMasVictorias != null)
                {
                    contenido += "Equipo con más victorias: " + equipoMasVictorias.Nombre + " (" + maxVictorias + ")\n";
                }
                if (equipoMasDerrotas != null)
                {
                    contenido += "Equipo con más derrotas: " + equipoMasDerrotas.Nombre + " (" + maxDerrotas + ")\n";
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
        /// Exporta el historial de los partidos jugados a un archivo de txt.
        /// </summary>
        /// <param name="rutaArchivo">Ruta completa donde se creará o sobrescribirá el archivo .txt</param>
        /// <returns>true si la exportación fue exitosa, false en caso contrario</returns>
        public bool ExportarDatosTxt(string rutaArchivo)
        {
            try
            {
                string contenido = "=== HISTORIAL DE PARTIDOS ===\n";

                foreach (Partido p in partidos)
                {
                    contenido += "Fecha y Hora: " + p.FechaHorario.ToString() + "\n";
                    contenido += "Lugar: " + p.Lugar + "\n";
                    contenido += "Categoría: " + p.Categoria + "\n";
                    contenido += "Resultado: " + p.EquipoLocal.Nombre + " " + p.GolesLocal + " - " +
                                    p.GolesVisitante + " " + p.EquipoVisitante.Nombre + "\n";
                    contenido += "------------------------------------------------\n";
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





