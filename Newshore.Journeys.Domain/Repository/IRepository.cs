using Newshore.Journeys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Newshore.Journeys.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public TEntity SearchRoute(string origin, string destination);

        public string PostJourney(Journey journey);
    }
}
