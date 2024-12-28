using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectE.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Client(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
