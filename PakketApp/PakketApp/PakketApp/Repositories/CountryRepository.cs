using PakketApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PakketApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country() { CountryId = 1, Name = "Belgie", FixedCountryPrice = 0.8M });
            countries.Add(new Country() { CountryId = 2, Name = "Nederland", FixedCountryPrice = 1.1M });
            countries.Add(new Country() { CountryId = 3, Name = "Frankrijk", FixedCountryPrice = 2.9M });
            return countries;
        }
    }
}
