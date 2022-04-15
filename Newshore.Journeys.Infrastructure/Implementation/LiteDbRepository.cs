using LiteDB;
using Newshore.Journeys.Domain.Entities;
using Newshore.Journeys.Domain.Repository;
using Newshore.Journeys.Infrastructure.DataModels;
using Newshore.Journeys.Infrastructure.InfrastructureService;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Newshore.Journeys.Infrastructure.Implementation
{
    public class LiteDbRepository : IInitialCharge, IRepository<Journey>
    {
        private List<FlightDataModel> Flights { get; set; }
        public async void DoInitialCharge()
        {
            Flights = new List<FlightDataModel>();
            HttpClient client = new HttpClient();
            string responseBody;
            HttpResponseMessage response = await client.GetAsync("https://recruiting-api.newshore.es/api/flights/2");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                responseBody = await response.Content.ReadAsStringAsync();
            }

        }

        public string PostJourney(Journey journey)
        {
            JourneyDataModel journeyDataModel = new JourneyDataModel()
            {
                Origin = journey.Origin,
                Destination = journey.Destination,
                Price = journey.Price
            };
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var journeysCollection = db.GetCollection<JourneyDataModel>("Journeys");
                journeysCollection.Insert(journeyDataModel);
            }
            return "";
        }

        public Journey SearchRoute(string origin, string destination)
        {
        }
    }
}
