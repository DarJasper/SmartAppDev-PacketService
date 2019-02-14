using PakketApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PakketApp.Repositories
{
    public class CourierRepository : ICourierRepository
    {
        public List<Courier> GetCouriers()
        {
            List<Courier> couriers = new List<Courier>();
            couriers.Add(new Courier() { CourierId = 1, Name = "DPD", Price = 5});
            couriers.Add(new Courier() { CourierId = 2, Name = "GLS", Price = 8 });
            couriers.Add(new Courier() { CourierId = 3, Name = "DHL", Price = 11 });
            return couriers;
        }
    }
}
