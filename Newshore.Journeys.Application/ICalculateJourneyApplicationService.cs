using Newshore.Journeys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Newshore.Journeys.Application
{
    public interface ICalculateJourneyApplicationService
    {
        public Journey CalculateJourney(string origin, string destination);
    }
}
