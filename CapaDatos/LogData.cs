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

        public LogData()
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


        public List<LogEntry> GetLogEntries()
        {
            var entries = new List<LogEntry>();
            string query = "SELECT Id, Timestamp, [User], Action, Details FROM LogEntries";

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var entry = new LogEntry
                        {
                            Id = (int)reader["Id"],
                            Timestamp = (DateTime)reader["Timestamp"],
                            User = reader["User"].ToString(),
                            Action = reader["Action"].ToString(),
                            Details = reader["Details"].ToString()
                        };
                        entries.Add(entry);
                    }
                }
            }
            return entries;
        }
    }

}
