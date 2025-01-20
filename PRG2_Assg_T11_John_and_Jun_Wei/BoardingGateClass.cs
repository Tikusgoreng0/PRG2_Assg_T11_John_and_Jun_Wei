using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodsPlan
{
    internal class BoardingGate
    {
        // Parameters
        public string GateName { get; set; }
        public bool SupportsCFFT { get; set; }
        public bool SupportsDDJB { get; set; }
        public bool SupportsLWTT { get; set; }
        public Flight Flight { get; set; }

        // Default Constructor
        public BoardingGate() { }

        // Constructors
        public BoardingGate(string gateName, bool supportsCFFT, bool supportsDDJB, bool supportsLWTT, Flight flight)
        {
            GateName = gateName;
            SupportsCFFT = supportsCFFT;
            SupportsDDJB = supportsDDJB;
            SupportsLWTT = supportsLWTT;
            Flight = flight;
        }

        // Methods
        public double CalculateFees()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Gate Name: " + GateName + "Supports CFFT: " + SupportsCFFT +
                "Supports DDJB: " + SupportsDDJB + "Supports LWTT: " + SupportsLWTT;
        }
    }
}
