using NorthWindEntities.Interfaces;
using NorthWindEntities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
    internal class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
           Console.WriteLine("ConsoleWrite: {0}, {1}, {2}",
               action.CreatedDateTime, action.User, action.Description);
        }
    }
}
