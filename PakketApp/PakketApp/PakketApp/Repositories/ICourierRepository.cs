using System.Collections.Generic;
using PakketApp.Models;

namespace PakketApp.Repositories
{
    public interface ICourierRepository
    {
        List<Courier> GetCouriers();
    }
}