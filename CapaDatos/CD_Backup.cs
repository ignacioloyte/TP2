using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.IO;
using System.Runtime.InteropServices;

namespace CapaDatos
{
    public class CD_Backup
    {
        private string _connectionString; // Define tu cadena de conexión aquí

        public CD_Backup()
        {
            _connectionString = Conexion.cadena;
        }

        public void BackupDatabase(DatabaseBackup backup)
        {
         

            //Genero sqlcommand
            string sqlCommand = $"BACKUP DATABASE [FerreteriaNeyte] TO DISK = '{backup.FilePath}' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of FerreteriaNeyte';";
            string dasdas = sqlCommand;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RestoreDatabase(DatabaseBackup backup)
        {
            string sqlCommand = $"USE master; ALTER DATABASE [FerreteriaNeyte] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [FerreteriaNeyte] FROM DISK = '{backup.FilePath}' WITH REPLACE; ALTER DATABASE [FerreteriaNeyte] SET MULTI_USER;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}



