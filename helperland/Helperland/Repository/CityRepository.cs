using Helperland.Data;
using Helperland.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly HelperlandContext _helperlandContext;

        public CityRepository(HelperlandContext helperlandContext)
        {
            this._helperlandContext = helperlandContext;
        }

        public List<City> GetCitiesByPostalCode(string postalCode)
        {
            List<City> cities = (from city in _helperlandContext.Cities
                                 join zipcode in _helperlandContext.Zipcodes on city.Id equals zipcode.CityId
                                 where zipcode.ZipcodeValue == postalCode
                                 select new City
                                 {
                                    Id = city.Id,
                                    CityName = city.CityName
                                 }).ToList();
            return cities;
        }
    }
}
