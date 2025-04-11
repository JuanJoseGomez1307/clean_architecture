using NorthWindEntities.Interfaces;
using NorthWindEntities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
    internal class AppLogger(IEnumerable<IUserActionWriter> writers):IAppLogger 
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach (var Writer in writers)
                Writer.Write(Log);
            
        }
    }
}
