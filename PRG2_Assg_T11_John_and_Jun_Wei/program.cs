//==========================================================
// Student Number	: S10259166
// Student Name	: John Gotinga
// Partner Name	: Yap Jun Wei
//==========================================================

// John: 2, 3, 5, 6, & 9

using GodsPlan;

//----------------------- John's Code ----------------------------
void InitData(Dictionary<string, Flight> flights)
{
    using (StreamReader work = new StreamReader("flights.csv"))
    {
        // Skip header
        string? please = work.ReadLine();

        while ((please = work.ReadLine()) != null)
        {
            // Splits commas and checks the special request code to make a class
            string[] daddy = please.Split(",");
            if (daddy[4] == "NORM")
            {
                NORMFlight tempFlight = new NORMFlight(daddy[0], daddy[1], daddy[2], Convert.ToDateTime(daddy[3]));
                flights[tempFlight.FlightNumber] = tempFlight;
            }
            else if (daddy[4] == "LWTT")
            {
                LWTTFlight tempFlight = new LWTTFlight(daddy[0], daddy[1], daddy[2], Convert.ToDateTime(daddy[3]));
                flights[tempFlight.FlightNumber] = tempFlight;
            }
            else if (daddy[4] == "DDJB")
            {
                DDJBFlight tempFlight = new DDJBFlight(daddy[0], daddy[1], daddy[2], Convert.ToDateTime(daddy[3]));
                flights[tempFlight.FlightNumber] = tempFlight;
            }
            else if (daddy[4] == "CFFT")
            {
                CFFTFlight tempFlight = new CFFTFlight(daddy[0], daddy[1], daddy[2], Convert.ToDateTime(daddy[3]));
                flights[tempFlight.FlightNumber] = tempFlight;
            }
        }
    }
}

//-----------------------------------------------------------------

void DisplayFlight(Dictionary<string, Flight> flights)
{
    Console.WriteLine("{0, -15} {1, -20} {2, -18} {3}",
        "Flight Number", "Origin", "Destination", "Expected Departure/Arrival");

    foreach (KeyValuePair<string, Flight> crashOut in flights)
    {
        Flight tempFlight = crashOut.Value;

        string? airline;
        if (tempFlight.FlightNumber.Substring(0, 2) == "SQ")

        Console.WriteLine("{0, -15} {1, -20} {2, -18} {3}",
            tempFlight.FlightNumber, tempFlight.Origin, tempFlight.Destination, tempFlight.ExpectedTime.ToString("h:mmtt"));
    }
}

//-----------------------------------------------------------------
// Program

//Make the dictionaries to store data
Dictionary<string, Flight> flights = new Dictionary<string, Flight>();
InitData(flights);

DisplayFlight(flights);

Console.WriteLine("No problems");

//----------------------- End of John's Code ---------------------------