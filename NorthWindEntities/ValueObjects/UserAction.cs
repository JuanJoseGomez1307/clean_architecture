using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEntities.ValueObjects
{
    public class UserAction(string user, string description)
    {
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;
    }
}
