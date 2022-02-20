using Helperland.Data;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public StateRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        public State GetStateByCityName(string cityName)
        {
            State objState = (from state in _helperlandContext.States
                    join city in _helperlandContext.Cities on state.Id equals city.StateId
                    where city.CityName == cityName
                    select new State
                    {
                        Id = state.Id,
                        StateName = state.StateName
                    }).FirstOrDefault();
            return objState;
        }
    }
}
