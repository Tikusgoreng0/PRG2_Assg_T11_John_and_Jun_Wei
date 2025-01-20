using GodsPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodsPlan
{
    class Airline
    {
        // Parameters
        public string Name { get; set; }
        public string Code { get; set; }
        public Dictionary<string, Flight> Flights { get; set; }

        // Default Constructor
        public Airline() { }

        // Constructors
        public Airline(string name, string code, Dictionary<string, Flight> flights)
        {
            Name = name;
            Code = code;
            Flights = flights;
        }

        // Methods
        public bool AddFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public double CalculateFees()
        {
            throw new NotImplementedException();
        }

        public bool RemoveFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Name: " + Name + "Code: " + Code + "Flgihts: " + Flights; // No idea how to display the Flights dictionary properly -John
        }
    }
}
