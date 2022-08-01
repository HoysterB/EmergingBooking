namespace EmergingBooking.Infrastructure.Cqrs.Commands;

public class CommandResult
{
    private static readonly CommandResult OkResult = new CommandResult(true, Enumerable.Empty<string>());

    public CommandResult(bool isSuccess, IEnumerable<string> errorMessages)
    {
        bool doNotExistsErrorMessage = errorMessages.Count() == 0;
        bool doExistsErrorMessage = !doNotExistsErrorMessage;

        if (isSuccess)
        {
            if (doExistsErrorMessage)
            {
                throw new ArgumentException(InternalErrorMessages.ErrorObjectIsProvidedForSuccess, nameof(errorMessages));
            }
            else
            {
                if (doNotExistsErrorMessage)
                {
                    throw new ArgumentException(InternalErrorMessages.ErrorObjectIsNotProvidedForFailure, nameof(errorMessages));
                }
            }
        }

        Success = isSuccess;
        ErrorMessages = errorMessages;
    }

    public bool Success { get; }
    public IEnumerable<string> ErrorMessages { get; }
    public bool Failure => !Success;

    public static CommandResult Ok()
    {
        return OkResult;
    }

    public static CommandResult Fail(string errorMessage)
    {
        return new CommandResult(false, new List<string> { errorMessage });
    }

    public static CommandResult Failt(IEnumerable<string> errorMessages)
    {
        return new CommandResult(false, errorMessages);
    }
}