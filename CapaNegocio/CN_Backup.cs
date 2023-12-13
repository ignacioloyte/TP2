using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio

{
    public class CN_Backup
    {
        private CD_Backup _dataLayer = new CD_Backup();

        public bool PerformBackup(DatabaseBackup backup,out string errorMessage)
        {
            try
            {
                _dataLayer.BackupDatabase(backup);
                errorMessage = string.Empty;
                // Lógica adicional si es necesaria
                return true;
        }
            catch (Exception ex)
            {
                errorMessage = ex.Message; // Captura el mensaje de error
                return false; // Devuelve false si ocurre una excepción
            }

        }

        public void PerformRestore(DatabaseBackup backup)
        {
            try
            {
                _dataLayer.RestoreDatabase(backup);
                // Lógica adicional si es necesaria
            }
            catch (Exception ex)
            {
                // Puedes hacer un log del error aquí, si es necesario
                throw new Exception($"Error al restaurar la base de datos: {ex.Message}", ex);
            }
        }
    }
}