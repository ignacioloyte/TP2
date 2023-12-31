﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    public class CN_Log
    {
        private LogData logData;


        public void LogAction(string user, string action, string details)
        {

            logData = new LogData();
            LogEntry logEntry = new LogEntry
            {
                Timestamp = DateTime.Now,
                User = user,
                Action = action,
                Details = details
            };

            logData.InsertLog(logEntry);
        }

        private LogData dal = new LogData();

        public List<LogEntry> GetAllLogEntries()
        {
            return dal.GetLogEntries();
        }
    }
}

