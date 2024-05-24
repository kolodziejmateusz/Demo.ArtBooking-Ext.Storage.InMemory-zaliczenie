using ArtBooking.Core.Model;
using ArtBooking.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtBooking.Core.Repositories
{
    public interface IEventRepository
    {
        Task<IQueryable<Event>> GetMultipleAsync();
    }
}
