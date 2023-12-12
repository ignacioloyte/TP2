using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    using System.Data.SqlClient;

    public class LogData
    {
        private string connectionString;

        public LogData(string connectionString)
        {
            this.connectionString = Conexion.cadena;
        }

        public void InsertLog(LogEntry logEntry)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.cadena))
            {
                string query = "INSERT INTO LogEntries ([Timestamp], [User], [Action], [Details]) VALUES (@Timestamp, @User, @Action, @Details)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Timestamp", logEntry.Timestamp);
                    command.Parameters.AddWithValue("@User", logEntry.User);
                    command.Parameters.AddWithValue("@Action", logEntry.Action);
                    command.Parameters.AddWithValue("@Details", logEntry.Details);


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
