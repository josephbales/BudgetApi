using BudgetApi.ApiModels;

namespace BudgetApi.RequestHandlers.Contracts
{
    public interface IUserRequestHandler : ICrudRequestHandler<User>
    {
        Task<User?> GetByEmail(Guid id);
    }
}
