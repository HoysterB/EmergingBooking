using EmergingBooking.Infrastructure.Cqrs.Commands;
using EmergingBooking.Management.Application.Commands;

namespace EmergingBooking.Management.Application.Handlers;

public class UpdateHotelAddressHandler : ICommandHandler<UpdateHotelAddress>
{
    public Task<CommandResult> ExecuteAsync(UpdateHotelAddress command)
    {
        throw new NotImplementedException();
    }
}