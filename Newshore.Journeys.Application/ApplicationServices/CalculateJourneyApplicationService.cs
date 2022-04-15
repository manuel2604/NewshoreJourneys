using Newshore.Journeys.Domain.Entities;
using Newshore.Journeys.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Newshore.Journeys.Application.ApplicationServices
{
    public class CalculateJourneyApplicationService : ICalculateJourneyApplicationService
    {
        private readonly IRepository<Journey> Repository;

        public CalculateJourneyApplicationService(IRepository<Journey> repository) => Repository = repository;
        public Journey CalculateJourney(string origin, string destination)
        {
            HttpClient client = new HttpClient();
            client.GetAsync("https://recruiting-api.newshore.es/api/flights/2");
        }
    }
}
