using BudgetApi.DataLayer.DomainEntities.Base;

namespace BudgetApi.DataLayer.DomainEntities
{
    public class MonthlyBudgetEntity : BaseEntity
    {
        public Guid? BudgetId { get; set; }
        public IEnumerable<Guid> UserIds { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly BudgetMonth { get; set; }
        public decimal BufferAmount { get; set; }
        public decimal CurrentBalance { get; set; }
        public IEnumerable<MonthlyBudgetItemEntity>? MonthlyBudgetItems { get; set; }
    }

    public class MonthlyBudgetItemEntity : BaseEntity
    {
        public Guid MonthlyBudgetId { get; set; }
        public Guid? BudgetItemId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public short? DueDay { get; set; }
        public bool IsPaid { get; set; }
        public string? Notes { get; set; }
        public string Type { get; set; } = null!;
    }
}
