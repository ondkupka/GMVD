using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupež_Století
{
    internal class Npcs
    {
        public string name;
        public string description;
        public bool isSuspicious;
        public Npcs(string name, string description, bool isSuspicious) { 
            this.name = name;
            this.description = description;
            this.isSuspicious = isSuspicious;
        }
    }
}
