using EmergingBooking.Infrastructure.Cqrs.Commands;
using EmergingBooking.Management.Application.Commands;

namespace EmergingBooking.Management.Application.Handlers;

public class AddRoomToHotelHandler : ICommandHandler<AddRoomToHotel>
{
    public Task<CommandResult> ExecuteAsync(AddRoomToHotel command)
    {
        throw new NotImplementedException();
    }
}