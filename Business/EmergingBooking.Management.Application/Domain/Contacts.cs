using EmergingBooking.Infrastructure.Cqrs.Domain;
using MonoidSharp;
using Newtonsoft.Json;

namespace EmergingBooking.Management.Application.Domain;

internal class Contacts : ValueObject
{
    [JsonConstructor]
    private Contacts(string email, string phone, string mobile)
    {
        Email = email;
        Phone = phone;
        Mobile = mobile;
    }
    
    public string Email { get; }
    public string Phone { get; }
    public string Mobile { get; }

    public static Outcome<Contacts> Create(PossibleBe<string> email, PossibleBe<string> phone,
        PossibleBe<string> mobile)
    {
        if (AreContactsValid(email, phone, mobile))
        {
            return Outcome.Successfully(new Contacts(email.Value, phone.Value, mobile.Value));
        }

        return Outcome.Failed<Contacts>("All contacts are invalid. Please verify all contact values!");
    }

    private static bool AreContactsValid(PossibleBe<string> email, PossibleBe<string> phone, PossibleBe<string> mobile)
    {
        return email.HasValue && phone.HasValue && mobile.HasValue;
    }

    protected override IEnumerable<object> GetEqualityProperties()
    {
        yield return Email;
        yield return Phone;
        yield return Mobile;
    }
}