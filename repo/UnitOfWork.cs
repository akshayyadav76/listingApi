using listingApi.data;
using listingApi.Irepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace listingApi.repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContaxt _context;
        private Irepo<Country> _countries;
        private Irepo<Hotel> _hotels;

        public UnitOfWork(DatabaseContaxt context)
        {
            _context = context;
        }
        public Irepo<Country> contries => _countries ??= new Repo<Country>(_context);
        public Irepo<Hotel> hotels => _hotels ??= new Repo<Hotel>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task save()
        {
            await _context.SaveChangesAsync();
        }


    }
}
