using ArtBooking.Core.Model;
using ArtBooking.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBooking.Storage.InMemory.Storage
{
    public class EventRepositoryInMemory : IEventRepository
    {
        private readonly ArtBookingDbContext _context;

        public EventRepositoryInMemory(ArtBookingDbContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<Event>> GetMultipleAsync()
        {
            return await Task.FromResult(_context.Events);
        }
    }
}
