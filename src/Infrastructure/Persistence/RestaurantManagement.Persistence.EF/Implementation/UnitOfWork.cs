using RestaurantManagement.Framework.Contract;

namespace RestaurantManagement.Persistence.EF.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task BeginTranAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task RollBackAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
