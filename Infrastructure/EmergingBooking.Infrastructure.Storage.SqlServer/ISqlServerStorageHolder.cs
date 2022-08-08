using System.Data;

namespace EmergingBooking.Infrastructure.Storage.SqlServer;

public interface ISqlServerStorageHolder
{
    IDbConnection DbConnection { get; }
}