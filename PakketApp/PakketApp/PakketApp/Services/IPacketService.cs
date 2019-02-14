using System.Collections.Generic;
using PakketApp.Models;

namespace PakketApp.Services
{
    public interface IPacketService
    {
        decimal CalculatePrice(decimal weight, Country country, Courier courier);
        List<Country> GetCountries();
        List<Courier> GetCouriers();
    }
}