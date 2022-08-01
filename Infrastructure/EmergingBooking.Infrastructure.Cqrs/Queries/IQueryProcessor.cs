namespace EmergingBooking.Infrastructure.Cqrs.Queries;

public interface IQueryProcessor
{
    Task<TResult> ExecuteQueryAsync<TQueryParameter, TResult>(TQueryParameter queryParameter) where TQueryParameter : IQuery;
}