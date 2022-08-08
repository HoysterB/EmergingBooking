using EmergingBooking.Infrastructure.Cqrs.Commands;
using EmergingBooking.Management.Application.Commands;

namespace EmergingBooking.Management.Application.Handlers;

internal class CreateHotelHandler : ICommandHandler<CreateHotel>
{
    public CreateHotelHandler()
    {
        
    }

    public async Task<CommandResult> ExecuteAsync(CreateHotel command)
    {
        return null;
    }
}