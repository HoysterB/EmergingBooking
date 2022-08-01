namespace EmergingBooking.Infrastructure.Cqrs.Commands;

internal static class InternalErrorMessages
{
    public static readonly string ErrorObjectIsNotProvidedForFailure =
        "You attempt to create a failure result, which must have an error, but a null error object was passed to the constructor.";

    public static readonly string ErrorObjectIsProvidedForSuccess =
        "You attempt to create a success result, which cannot have an error, but a non-null error object was passed to the constructor.";
}