namespace RestaurantManagement.Framework.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTranAsync(CancellationToken cancellationToken);
        Task RollBackAsync(CancellationToken cancellationToken);
        Task CommitAsync(CancellationToken cancellationToken);
    }
}