using BudgetApi.DataLayer.DomainEntities.Base;

namespace BudgetApi.DataLayer.Repositories.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> Add(T entity);
        Task Delete(Guid id);
        Task<T?> Update(T entity);
        Task<T?> Get(Guid id);
    }
}
