using System.Collections.Generic;
using PakketApp.Models;

namespace PakketApp.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetCountries();
    }
}