using Coordinator.Services.Abstraction;

namespace Coordinator.Services
{
    public class TransactionService : ITransactionService
    {
        public Task<Guid> CreateTransactionAsync()
        {
            throw new NotImplementedException();
        }
        public Task PrepareServicesAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }
        public Task<bool> CheckReadyServicesAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }
        public Task<bool> CheckTransactionStateServicesAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task RollbackAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
