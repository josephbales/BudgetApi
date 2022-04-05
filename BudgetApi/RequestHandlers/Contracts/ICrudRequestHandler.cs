using BudgetApi.ApiModels.Base;

namespace BudgetApi.RequestHandlers.Contracts
{
    public interface ICrudRequestHandler<T> where T : BaseApiModel
    {
        Task<T?> Create(T model);
        Task<T?> Read(Guid id);
        Task<T?> Update(T model);
        Task<Guid?> Delete(Guid id);
    }
}
