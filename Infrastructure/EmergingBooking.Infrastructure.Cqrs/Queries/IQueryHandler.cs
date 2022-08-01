namespace EmergingBooking.Infrastructure.Cqrs.Queries;

public interface IQueryHandler<in TQueryParameter, TResult> where TQueryParameter : IQuery
{
    Task<TResult> ExecuteQueryAsync(TQueryParameter queryParameter);
}
