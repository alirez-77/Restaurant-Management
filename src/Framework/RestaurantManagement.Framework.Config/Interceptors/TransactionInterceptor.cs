using Castle.DynamicProxy;
using RestaurantManagement.Framework.Contract;

namespace BRE.Framework.Config.Interceptors
{
    public class TransactionInterceptor : IAsyncInterceptor
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionInterceptor(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async void InterceptAsynchronous(IInvocation invocation)
        {
            try
            {
                await _unitOfWork.BeginTranAsync(cancellationToken: default);
                invocation.Proceed();
                await _unitOfWork.CommitAsync(cancellationToken: default);
            }
            catch
            {
                await _unitOfWork.RollBackAsync(cancellationToken: default);
                throw;
            }
        }

        public async void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
            try
            {
                await _unitOfWork.BeginTranAsync(cancellationToken: default);
                invocation.Proceed();
                await _unitOfWork.CommitAsync(cancellationToken: default);
            }
            catch
            {
                await _unitOfWork.RollBackAsync(cancellationToken: default);
                throw;
            }
        }

        public async void InterceptSynchronous(IInvocation invocation)
        {
            try
            {
                await _unitOfWork.BeginTranAsync(cancellationToken: default);
                invocation.Proceed();
                await _unitOfWork.CommitAsync(cancellationToken: default);
            }
            catch
            {
                await _unitOfWork.RollBackAsync(cancellationToken: default);
                throw;
            }
        }
    }
}