using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaDeportiva.Interfaces
{
    /// <summary>
    /// Define el contrato para las clases que tienen la capacidad de exportar sus datos a un archivo externo.
    /// </summary>
    public interface IExportable
    {
        /// <summary>
        /// Exporta la información de la clase a un archivo de texto en la ruta especificada.
        /// </summary>
        /// <param name="rutaArchivo">Ruta completa donde se creará o sobrescribirá el archivo .txt</param>
        /// <returns>true si la exportación fue exitosa, false en caso contrario.</returns>
        bool ExportarDatosTxt(string rutaArchivo);
        
    }
}
