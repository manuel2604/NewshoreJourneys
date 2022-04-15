using System;
using System.Collections.Generic;
using System.Text;

namespace Newshore.Journeys.Infrastructure.DataModels
{
    public class JourneyDataModel
    {
        public List<FlightDataModel> Flights { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public double Price { get; set; }
    }
}
