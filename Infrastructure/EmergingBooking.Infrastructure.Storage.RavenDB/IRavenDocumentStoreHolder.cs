using Raven.Client.Documents;

namespace EmergingBooking.Infrastructure.Storage.RavenDB;

internal interface IRavenDocumentStoreHolder
{
    IDocumentStore Store { get; }
}