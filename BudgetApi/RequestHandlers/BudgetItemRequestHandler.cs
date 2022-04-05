using BudgetApi.ApiModels;
using BudgetApi.RequestHandlers.Contracts;

namespace BudgetApi.RequestHandlers
{
    public class BudgetItemRequestHandler : IBudgetItemRequestHandler
    {
        public Task<BudgetItem?> Create(BudgetItem model)
        {
            throw new NotImplementedException();
        }

        public Task<Guid?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BudgetItem?> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BudgetItem?> Update(BudgetItem model)
        {
            throw new NotImplementedException();
        }
    }
}
