using BudgetApi.ApiModels;
using BudgetApi.RequestHandlers.Contracts;

namespace BudgetApi.RequestHandlers
{
    public class MonthlyBudgetRequestHandler : IMonthlyBudgetRequestHandler
    {
        public Task<MonthlyBudget?> Create(MonthlyBudget model)
        {
            throw new NotImplementedException();
        }

        public Task<Guid?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MonthlyBudget?> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MonthlyBudget?> Update(MonthlyBudget model)
        {
            throw new NotImplementedException();
        }
    }
}
