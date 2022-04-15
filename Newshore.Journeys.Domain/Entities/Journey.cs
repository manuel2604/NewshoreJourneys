using System;
using System.Collections.Generic;
using System.Text;

namespace Newshore.Journeys.Domain.Entities
{
    public class Journey
    {
        public List<Flight> Flights { get; private set; }

        public string Origin { get; private set; }

        public string Destination { get; private set; }

        public double Price { get; private set; }

        private Journey(string origin, string destination) => (Origin, Destination) = (origin, destination);

        public static Journey Create(string origin, string destionation)
        {
            return new Journey(origin, destionation);
        }

        public void CalculatePrice()
        {
            Price = 0;
            foreach(Flight flight in Flights)
            {
                Price += flight.Price;
            }
        }

        public void AddFlight(Flight flight)
        {
            Flights.Add(flight);
        }
    }
}
