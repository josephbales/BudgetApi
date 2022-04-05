using BudgetApi.DataLayer.DomainEntities.Base;

namespace BudgetApi.DataLayer.DomainEntities
{
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; } = null!;
        public string? DisplayName { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
