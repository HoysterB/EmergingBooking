using EmergingBooking.Infrastructure.Cqrs.Commands;

namespace EmergingBooking.Management.Application.Commands;

public class UpdateHotelContacts : ICommand
{
    public UpdateHotelContacts(Guid hotelCode, string newEmail, string newPhone, string newMobile)
    {
        HotelCode = hotelCode;
        NewEmail = newEmail;
        NewPhone = newPhone;
        NewMobile = newMobile;
    }

    public Guid HotelCode { get; }
    public string NewEmail { get; }
    public string NewPhone { get; }
    public string NewMobile { get; }
}