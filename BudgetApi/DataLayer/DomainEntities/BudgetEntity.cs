using BudgetApi.DataLayer.DomainEntities.Base;

namespace BudgetApi.DataLayer.DomainEntities
{
    public class BudgetEntity : BaseEntity
    {
        public IEnumerable<Guid> UserIds { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IEnumerable<BudgetItemEntity>? BudgetItems { get; set; }
    }

    public class BudgetItemEntity : BaseEntity
    {
        public Guid BudgetId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public short? DueDay { get; set; }
        public string? Notes { get; set; }
        public string Type { get; set; } = null!;
    }
}
