using listingApi.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.Irepo
{
   public interface IUnitOfWork : IDisposable
    {
        Irepo<Country> contries { get; }
        Irepo<Hotel> hotels { get; }
        Task save();

    }
}
