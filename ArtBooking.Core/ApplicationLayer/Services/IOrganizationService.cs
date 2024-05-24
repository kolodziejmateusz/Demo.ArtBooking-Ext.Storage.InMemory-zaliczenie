namespace ArtBooking.Application;

using ArtBooking.Core.Model;
using ArtBooking.Model;
using ArtBooking.Storage;

public interface IOrganizationService : IServiceBase<Organization>
{
    Task<OperationResult<dynamic>> AddNewLocationAsync(Location item);

    Task<OperationResult<dynamic>> DeleteLocationAsync(int locationId);

    Task<IQueryable<Event>> GetEventsMultipleAsync();
}