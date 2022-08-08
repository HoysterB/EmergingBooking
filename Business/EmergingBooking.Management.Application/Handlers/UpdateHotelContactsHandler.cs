using EmergingBooking.Infrastructure.Cqrs.Commands;
using EmergingBooking.Management.Application.Commands;

namespace EmergingBooking.Management.Application.Handlers;

public class UpdateHotelContactsHandler : ICommandHandler<UpdateHotelContacts>
{
    public Task<CommandResult> ExecuteAsync(UpdateHotelContacts command)
    {
        throw new NotImplementedException();
    }
}