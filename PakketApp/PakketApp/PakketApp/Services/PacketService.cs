using PakketApp.Models;
using PakketApp.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PakketApp.Services
{
    public  class PacketService : IPacketService
    {
        private ICourierRepository courierRepository;
        private ICountryRepository countryRepository;

        public PacketService(ICourierRepository courierRepository, ICountryRepository countryRepository)
        {
            this.courierRepository = courierRepository;
            this.countryRepository = countryRepository;
        }

        public List<Courier> GetCouriers()
        {
            return courierRepository.GetCouriers();
        }

        public List<Country> GetCountries()
        {
            return countryRepository.GetCountries();
        }

        public decimal CalculatePrice(decimal weight, Country country, Courier courier)
        {
            //Geen accolades nodig omdat maar 1 regels is
            //Ook geen else nodig
            if (weight <= 30)
                return courier.Price + country.FixedCountryPrice;
         
            return 75M;
        }
    }
}
