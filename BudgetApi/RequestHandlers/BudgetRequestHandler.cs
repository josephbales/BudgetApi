using BudgetApi.ApiModels;
using BudgetApi.RequestHandlers.Contracts;

namespace BudgetApi.RequestHandlers
{
    public class BudgetRequestHandler : IBudgetRequestHandler
    {
        public Task<Budget?> Create(Budget model)
        {
            throw new NotImplementedException();
        }

        public Task<Guid?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Budget?> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Budget?> Update(Budget model)
        {
            throw new NotImplementedException();
        }
    }
}
