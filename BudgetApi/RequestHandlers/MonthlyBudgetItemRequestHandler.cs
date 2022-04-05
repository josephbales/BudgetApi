using BudgetApi.ApiModels;
using BudgetApi.RequestHandlers.Contracts;

namespace BudgetApi.RequestHandlers
{
    public class MonthlyBudgetItemRequestHandler : IMonthlyBudgetItemRequestHandler
    {
        public Task<MonthlyBudgetItem?> Create(MonthlyBudgetItem model)
        {
            throw new NotImplementedException();
        }

        public Task<Guid?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MonthlyBudgetItem?> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MonthlyBudgetItem?> Update(MonthlyBudgetItem model)
        {
            throw new NotImplementedException();
        }
    }
}
